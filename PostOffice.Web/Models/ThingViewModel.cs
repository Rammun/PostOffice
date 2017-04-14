using System.ComponentModel.DataAnnotations;

namespace PostOffice.Web.Models
{
    public class ThingViewModel
    {
        [Required]
        [Display(Name = "Наименование")]
        public string Name { get; set; }
    }
}