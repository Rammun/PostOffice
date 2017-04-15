using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostOffice.Web.Entity
{
    public class Member
    {
        /// <summary>
        /// Идентификационный ключ
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }
        
        /// <summary>
        /// Коллекция полученных посылок
        /// </summary>
        [InverseProperty("Recipient")]
        public virtual ICollection<Parcel> Received { get; set; }

        /// <summary>
        /// Коллекция отправленных посылок
        /// </summary>
        [InverseProperty("Sender")]
        public virtual ICollection<Parcel> Send { get; set; }
    }
}