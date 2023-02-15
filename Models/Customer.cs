using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Please enter your First Name")]
        [DisplayName("First Name")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Please enter your Last Name")]
        [DisplayName("Last Name")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Please enter your current address")]
        [DisplayName("Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [DisplayName("Phone Number")]
        public string Phone { get; set; }

        public Customer()
        {

        }
        public Customer(int customerID, string fName, string lName, string address, string phone)
        {
            CustomerID = customerID;
            FName = fName;
            LName = lName;
            Address = address;
            Phone = phone;
        }
    }
}