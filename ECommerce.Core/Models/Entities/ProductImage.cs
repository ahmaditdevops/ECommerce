// الموقع: ECommerce.Core/Models/Entities/ProductImage.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Core.Models.Entities
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string ImageUrl { get; set; }

        [StringLength(100)]
        public string AltText { get; set; }

        [Display(Name = "Is Main Image?")]
        public bool IsMainImage { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}