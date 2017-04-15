using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PostOffice.Web.Models
{
    public class ParcelViewModel
    {
        /// <summary>
        /// Вес
        /// </summary>
        [Required]
        [Display(Name = "Вес")]
        public double Weight { get; set; }

        /// <summary>
        /// ФИО получателя
        /// </summary>
        [Required]
        [Display(Name = "ФИО получателя")]
        public string RecipientFullName { get; set; }

        /// <summary>
        /// ФИО отправителя
        /// </summary>
        [Required]
        [Display(Name = "ФИО отправителя")]
        public string SenderFullName { get; set; }

        /// <summary>
        /// Адресс получателя
        /// </summary>
        [Required]
        [Display(Name = "Адрес получателя")]
        public string RecipientAdress { get; set; }

        /// <summary>
        /// Адресс отправителя
        /// </summary>
        [Required]
        [Display(Name = "Адрес отправителя")]
        public string SenderAdress { get; set; }

        /// <summary>
        /// Опись
        /// </summary>
        [Display(Name = "Опись")]
        public string Inventory { get; set; }
    }
}