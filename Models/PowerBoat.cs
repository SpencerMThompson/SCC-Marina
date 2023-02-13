using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SCC_Marina.Models
{
    public class PowerBoat : Boat
    {
        public string NumberOfEngines { get; set; }
        public string FuelType { get; set; }

        public PowerBoat()
        {

        }

        public PowerBoat(string numberOfEngines, string fuelType)
        {
            NumberOfEngines = numberOfEngines;
            FuelType = fuelType;
        }
    }
}