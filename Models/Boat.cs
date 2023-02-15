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
        public string BoatType { get; set; }

        [Required(ErrorMessage = "Please enter a valid registration")]
        [DisplayName("Registration")]
        public string Registration { get; set; }

        [Required(ErrorMessage = "Please provide your boat length")]
        [DisplayName("Boat Length")]
        public string BoatLength { get; set; }

        [Required(ErrorMessage = "Please provide the boat's manufacturer")]
        [DisplayName("Manufacturer")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Please enter the year of boat")]
        [DisplayName("Year")]
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