using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SCC_Marina.Models
{
    public class Lease
    {
        public int LeaseId { get; set; }
        public int BoatId { get; set; }
        public int CustomerId { get; set; }
        public int SlipId { get; set; }
        public string LeaseType { get; set; }
        public float Rate { get; set; }
        public DateTime StartDate { get; set; }
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