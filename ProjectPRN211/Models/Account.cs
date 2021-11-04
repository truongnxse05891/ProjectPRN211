using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ProjectPRN211.Models
{
    public partial class Account
    {
        [Key]
        public int AccountId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Fullname not empty.")]
        public string FullName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email not empty.")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]

        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password not empty.")]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Address not empty.")]
        public string Address { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Date of birth not empty.")]
        public DateTime DateOfBirth { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Gender not empty.")]
        public bool Gender { get; set; }

        [NotMapped]
        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
