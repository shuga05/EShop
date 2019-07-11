using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EShop.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [EmailAddress]
        [Compare("EmailAddress", ErrorMessage = "Must match!")]
        public string ConfirmEmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Must be more than 5!")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Must match!")]
        [MinLength(5, ErrorMessage = "Must be more than 5!")]
        public string ConfirmPassword { get; set; }
    }
}