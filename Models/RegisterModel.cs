using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "An user is required")]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        [DisplayName("Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please choose a password")]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm a password")]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }

        [StringLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [DisplayName("Email")]
        public string Email { get; set; }
    }
}