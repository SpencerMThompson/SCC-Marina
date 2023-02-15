using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class Boat
    {
        [Key]
        public int BoatID { get; set; }

        [Required(ErrorMessage = "Please provide the type of boat (Sailboat or Powerboat)")]
        [DisplayName("Boat Type")]
        [StringLength(25, ErrorMessage = "Boat Type can't be longer than 25 characters")]
        public string BoatType { get; set; }

        [Required(ErrorMessage = "Please enter a valid registration")]
        [DisplayName("Registration")]
        [StringLength(25, ErrorMessage = "Registration can't be longer than 25 characters")]
        public string Registration { get; set; }

        [Required(ErrorMessage = "Please provide your boat length")]
        [DisplayName("Boat Length")]
        [StringLength(10, ErrorMessage = "Boat Length can't be longer than 10 characters")]
        public string BoatLength { get; set; }

        [Required(ErrorMessage = "Please provide the boat's manufacturer")]
        [DisplayName("Manufacturer")]
        [StringLength(25, ErrorMessage = "Manufacturer can't be longer than 25 characters")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Please enter the year of boat")]
        [DisplayName("Year")]
        [StringLength(4, ErrorMessage = "Year can't be longer than 4 characters")]
        public string Year { get; set; }

        public Boat()
        {

        }

        public Boat(int boatID, string boatType, string registration, string boatLength, string manufacturer, string year)
        {
            BoatID = boatID;
            BoatType = BoatType;
            Registration = registration;
            BoatLength = boatLength;
            Manufacturer = manufacturer;
            Year = year;
        }

    }
}