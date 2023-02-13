using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SCC_Marina.Models
{
    public class Boat
    {
        public int BoatID { get; set; }
        public string? BoatType { get; set; }
        public string Registration { get; set; }
        public string BoatLength { get; set; }
        public string Manufacturer { get; set; }
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