using System.ComponentModel.DataAnnotations;

namespace PostOffice.Web.Models
{
    public class ParcelRegisterViewModel
    {
        /// <summary>
        /// Вес
        /// </summary>
        [Required]
        [Display(Name = "Вес")]
        public double Weight { get; set; }

        /// <summary>
        /// Получатель
        /// </summary>
        [Display(Name = "Получатель")]
        public MemberViewModel Recipient { get; set; }
        
        /// <summary>
        /// Отправитель
        /// </summary>
        [Display(Name = "Отправитель")]
        public MemberViewModel Sender { get; set; }

        /// <summary>
        /// Опись
        /// </summary>
        [Display(Name = "Опись")]
        public string Inventory { get; set; }
    }
}