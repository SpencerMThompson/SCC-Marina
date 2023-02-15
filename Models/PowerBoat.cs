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
        [StringLength(10, ErrorMessage = "Number of engines can't be longer than 10 characters")]
        public string NumberOfEngines { get; set; }

        [Required(ErrorMessage = "Please provide the fuel type")]
        [DisplayName("Fuel Type")]
        [StringLength(25, ErrorMessage = "Fuel Type can't be longer than 25 characters")]
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