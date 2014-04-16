using System.ComponentModel.DataAnnotations;

namespace Museum.Core.ViewModels.User
{
    public class UserInfoViewModel
    {
        [DataType(DataType.Text)]
        [Display(Name = "Ім'я: ")]
        public string Name { get; set; }

        [Display(Name = "Фото")]
        public string ProfilePicUrl { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
