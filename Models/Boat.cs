using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class Boat
    {
        public int BoatID { get; set; }
        public string Registration { get; set; }
        public string BoatLength { get; set; }
        public string Manufacturer { get; set; }
        public string Year { get; set; }

        public Boat()
        {

        }

        public Boat(int boatID, string registration, string boatLength, string manufacturer, string year)
        {
            BoatID = boatID;
            Registration = registration;
            BoatLength = boatLength;
            Manufacturer = manufacturer;
            Year = year;
        }

    }
}