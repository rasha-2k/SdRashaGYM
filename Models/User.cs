using System.ComponentModel.DataAnnotations;

namespace SdRashaGYMV2.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public required string Username { get; set; }
        [Required]
        public required string Password { get; set; }
    }
}
