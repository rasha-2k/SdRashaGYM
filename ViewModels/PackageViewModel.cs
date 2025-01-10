using System.ComponentModel.DataAnnotations;

namespace SdRashaGYMV2.ViewModels
{
    public class PackageViewModel
    {
        public int Id { get; set; }

        [Required]
        public string PackageName { get; set; }

        [Required]
        [Range(1, 365, ErrorMessage = "Duration must be between 1 and 365")]
        public string? Duration { get; set; }

        [Required]
        [Range(0, 9999.99, ErrorMessage = "Price must be between 0 and 9999.99.")]
        public decimal? Price { get; set; }

        [Required]
        public string? Days { get; set; }
        public List<string> SelectedDays { get; set; }

        public string Description { get; set; }

    }
}
