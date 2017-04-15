using System.ComponentModel.DataAnnotations;

namespace PostOffice.Web.Models
{
    public class MemberViewModel
    {
        /// <summary>
        /// Имя
        /// </summary>
        [Required]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        [Required]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        [Required]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        [Required]
        [Display(Name = "Адрес")]
        public string Address { get; set; }
    }
}