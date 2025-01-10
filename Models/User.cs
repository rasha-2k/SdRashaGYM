using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SdRashaGYMV2.Models
{
    public class User : IdentityUser
    {
       

        [StringLength(100)]
        public string? FullName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public bool? IsMale { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

    }
}
