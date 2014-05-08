using System.ComponentModel.DataAnnotations;

namespace Museum.Core.ViewModels.User
{
    public class LocalPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "{0} Повинно бути не менше {2} символів.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Новий пароль")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Підтвердіть новий пароль")]
        [Compare("NewPassword", ErrorMessage = "Новий пароль і підтвердження пароля не збігаються.")]
        public string ConfirmPassword { get; set; }
    }
}
