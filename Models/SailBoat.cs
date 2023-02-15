using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class SailBoat : Boat
    {
        [Required(ErrorMessage = "Please provide the keel depth")]
        [DisplayName("KeelDepth")]
        [StringLength(10, ErrorMessage = "Keel Depth can't be longer than 10 characters")]
        public string KeelDepth { get; set; }

        [Required(ErrorMessage = "Please list the number of sails on the boat")]
        [DisplayName("NumberOfSails")]
        [StringLength(10, ErrorMessage = "Number of Sails can't be longer than 10 characters")]
        public string NumberOfSails { get; set; }

        [DisplayName("MotorType")]
        [StringLength(25, ErrorMessage = "Motor Type can't be longer than 25 characters")]
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