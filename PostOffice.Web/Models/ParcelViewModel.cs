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
        public string RecipientFio { get; set; }

        /// <summary>
        /// ФИО отправителя
        /// </summary>
        [Required]
        [Display(Name = "ФИО отправителя")]
        public string SenderFio { get; set; }

        /// <summary>
        /// Адресс получателя
        /// </summary>
        [Required]
        [Display(Name = "Адрес получателя")]
        public string RecipAdress { get; set; }

        /// <summary>
        /// Адресс отправителя
        /// </summary>
        [Required]
        [Display(Name = "Адрес отправителя")]
        public string SendAdress { get; set; }

        /// <summary>
        /// Опись
        /// </summary>
        [Display(Name = "Опись")]
        public IList<ThingViewModel> Inventory { get; set; }
    }
}