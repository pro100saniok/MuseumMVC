using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Museum.Model.Models.Gallery
{
    public sealed class ImageCategory
    {
        public ImageCategory()
        {
            Images = new List<Image>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageCategoryId { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Категорія")]
        public string Name { get; set; }

        public ICollection<Image> Images { get; set; }

    }
}
