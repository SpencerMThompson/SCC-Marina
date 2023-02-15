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
        [StringLength(25, ErrorMessage = "First Name can't be longer than 25 characters")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Please enter your Last Name")]
        [DisplayName("Last Name")]
        [StringLength(25, ErrorMessage = "Last Name can't be longer than 25 characters")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Please enter your current address")]
        [DisplayName("Address")]
        [StringLength(100, ErrorMessage = "Address can't be longer than 100 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [DisplayName("Phone Number")]
        [StringLength(11, ErrorMessage = "Phone Number can't be longer than 11 characters")]
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