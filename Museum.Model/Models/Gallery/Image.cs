using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Museum.Model.Models.Gallery
{
    public class Image
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Назва")]
        public string Title { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Фото")]
        public string ImageUrl { get; set; }

        public int ImageCategoryId { get; set; }

        public ImageCategory ImageCategory { get; set; }
    }
}
