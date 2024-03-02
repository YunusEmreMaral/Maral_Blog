using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class RoleViewModel
    {
        [Display(Name = "Rol Adı")]
        [Required(ErrorMessage = "Lütfen rol adınızı giriniz")]
        public string Name { get; set; }
    }
}
