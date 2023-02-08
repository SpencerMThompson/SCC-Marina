using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class Lease
    {
        public Lease(int leaseId, int boatId, int customerId, int slipId, float rate, DateTime startDate, DateTime endDate, Array leases)
        {
            LeaseId = leaseId;
            BoatId = boatId;
            CustomerId = customerId;
            SlipId = slipId;
            Rate = rate;
            StartDate = startDate;
            EndDate = endDate;
            Leases = leases;
        }

        public Lease()
        {
        }

        public int LeaseId { get; set; }
        public int BoatId { get; set; }
        public int CustomerId { get; set; }
        public int SlipId { get; set; }
        public float Rate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Array Leases { get; set; }


    }
}