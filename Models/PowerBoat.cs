using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class PowerBoat : Boat
    {
        [Required(ErrorMessage = "Please provide the number of engines")]
        [DisplayName("Number Of Engines")]
        public string NumberOfEngines { get; set; }

        [Required(ErrorMessage = "Please provide the fuel type")]
        [DisplayName("Fuel Type")]
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