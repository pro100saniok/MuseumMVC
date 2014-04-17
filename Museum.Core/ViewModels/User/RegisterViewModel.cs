using System.ComponentModel.DataAnnotations;

namespace Museum.Core.ViewModels.User
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Обов'язкове поле")]
        [Display(Name = "Пошта")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Обов'язкове поле")]
        [Display(Name = "Ім'я")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [StringLength(100, ErrorMessage = "{0} має бути не менше {2} символів.", MinimumLength = 6)]
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Повтор пароля")]
        [Compare("Password", ErrorMessage = "Пароль і підтвердження пароля не збігаються.")]
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Обов'язкове поле")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }
    }
}
