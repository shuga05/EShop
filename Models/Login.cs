using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EShop.Models
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }

        [Required]
        [EmailAddress]
        public string ConfirmEmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}