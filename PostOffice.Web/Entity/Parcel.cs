using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PostOffice.Web.Entity
{
    public class Parcel
    {
        /// <summary>
        /// Идентификационный номер
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// ФИО получателя
        /// </summary>
        public string RecipientFio { get; set; }

        /// <summary>
        /// ФИО отправителя
        /// </summary>
        public string SenderFio { get; set; }

        /// <summary>
        /// Адресс получателя
        /// </summary>
        public string RecipAdress { get; set; }

        /// <summary>
        /// Адресс отправителя
        /// </summary>
        public string SendAdress { get; set; }

        /// <summary>
        /// Опись
        /// </summary>
        public virtual IList<Thing> Inventory { get; set; }

        public Parcel()
        {
            Inventory = new List<Thing>();
        }
    }
}