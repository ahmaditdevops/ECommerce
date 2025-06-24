// الموقع: ECommerce.Core/ViewModels/Shared/ImageVM.cs
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.ViewModels.Shared
{
    public class ImageVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Image URL is required")]
        [Url(ErrorMessage = "Invalid URL format")]
        [Display(Name = "Image URL")]
        public string Url { get; set; }

        [StringLength(100, ErrorMessage = "Alt text cannot exceed 100 characters")]
        [Display(Name = "Alternative Text")]
        public string AltText { get; set; }

        [Display(Name = "Main Image")]
        public bool IsMain { get; set; }
    }
}