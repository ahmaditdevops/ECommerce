// الموقع: ECommerce.Core/Models/Settings/SiteSettings.cs
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Models.Settings
{
    public class SiteSettings
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string SiteName { get; set; }

        [DataType(DataType.ImageUrl)]
        public string LogoUrl { get; set; }

        [Required]
        [StringLength(3)]
        public string DefaultCurrency { get; set; } = "SAR";

        public bool MaintenanceMode { get; set; }
    }
}