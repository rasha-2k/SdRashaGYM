using System.ComponentModel.DataAnnotations;

namespace SdRashaGYMV2.Models
{
    public class Package
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Package name cannot exceed 100 characters.")]
        public required string? PackageName { get; set; }

        [StringLength(200, ErrorMessage = "Image path cannot exceed 200 characters.")]

        [Required]
        [Range(1, 365, ErrorMessage = "Duration must be between 1 and 365")]
        public required string? Duration { get; set; } 

        [Required]
        [Range(0, 9999.99, ErrorMessage = "Price must be between 0 and 9999.99.")]
        public required decimal? Price { get; set; }

        [Required]
        public string? Days { get; set; }

        [StringLength(500)]
        public string? Description { get; set; } // (optional)
    }
}
