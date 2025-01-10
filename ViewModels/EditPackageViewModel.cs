using System;
using System.ComponentModel.DataAnnotations;

namespace SdRashaGYMV2.ViewModels
{ 
    public class EditPackageViewModel
    {
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "Package name cannot exceed 100 characters.")]
        public required string? PackageName { get; set; }


        [Range(1, 365, ErrorMessage = "Duration must be between 1 and 365")]
        public required string? Duration { get; set; }

        [Range(0, 9999.99, ErrorMessage = "Price must be between 0 and 9999.99.")]
        public required decimal? Price { get; set; }

        public string? Days { get; set; }
        public List<string> SelectedDays { get; set; }


        [StringLength(500)]
        public string? Description { get; set; } // (optional)
    }
}