using System;
using System.ComponentModel.DataAnnotations;

namespace SdRashaGYMV2.ViewModels
{ 
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Gender")]
        public bool? IsMale { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
    }
}