using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SCC_Marina.Models
{
    public class SailBoat : Boat
    {
        public string KeelDepth { get; set; }
        public string NumberOfSails { get; set; }
        public string MotorType { get; set; }

        public SailBoat()
        {

        }

        public SailBoat(string keelDepth, string numberOfSails, string motorType)
        {
            KeelDepth = keelDepth;
            NumberOfSails = numberOfSails;
            MotorType = motorType;
        }
    }
}