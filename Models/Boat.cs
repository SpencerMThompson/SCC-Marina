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
    }
}