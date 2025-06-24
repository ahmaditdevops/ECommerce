// الموقع: ECommerce.Core/Models/Identity/ApplicationUser.cs
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ProfilePicture { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
    }
}