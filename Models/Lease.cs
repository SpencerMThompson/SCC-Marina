using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class Lease
    {
        [DisplayName("LeaseID")]
        public int LeaseId { get; set; }

        [DisplayName("BoatID")]
        public int BoatId { get; set; }

        [DisplayName("CustomerID")]
        public int CustomerId { get; set; }

        [DisplayName("SlipID")]
        public int SlipId { get; set; }

        [Required(ErrorMessage = "Please provide the type of lease (Day or annual): ")]
        [DisplayName("Annual or Daily Lease")]
        public string LeaseType { get; set; }

        [DisplayName("Rate")]
        public float Rate { get; set; }

        [Required(ErrorMessage = "Provide day lease will begin: ")]
        [DisplayName("Start Date of Lease")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Provide day lease will end: ")]
        [DisplayName("End Date of Lease")]
        public DateTime EndDate { get; set; }

        public IEnumerable<string> Leases { get; set; }


        public Lease()
        {
        }


        public Lease(int leaseId, int boatId, int customerId, int slipId, string leaseType, float rate, DateTime startDate, DateTime endDate, IEnumerable<string> leases)
        {
            LeaseId = leaseId;
            BoatId = boatId;
            CustomerId = customerId;
            SlipId = slipId;
            LeaseType = leaseType;
            Rate = rate;
            StartDate = startDate;
            EndDate = endDate;
            Leases = leases;
        }


    }
}