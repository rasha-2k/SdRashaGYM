﻿using System.ComponentModel.DataAnnotations;

namespace SdRashaGYMV2.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
