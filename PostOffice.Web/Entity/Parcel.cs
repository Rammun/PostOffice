using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        /// Опись
        /// </summary>
        public string Inventory { get; set; }

        /// <summary>
        /// Идентификационный номер получателя в бд
        /// </summary>
        public int RecipientId { get; set; }

        /// <summary>
        /// Получатель
        /// </summary>
        [ForeignKey(nameof(RecipientId))]
        public Member Recipient { get; set; }

        /// <summary>
        /// Идентификационный номер отправителя в бд
        /// </summary>
        public int SenderId { get; set; }

        /// <summary>
        /// Отправитель
        /// </summary>
        [ForeignKey(nameof(SenderId))]
        public Member Sender { get; set; }
    }
}