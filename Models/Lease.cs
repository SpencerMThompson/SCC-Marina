using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class Lease
    {
        public int LeaseId { get; set; }
        public int BoatId { get; set; }
        public int CustomerId { get; set; }
        public int SlipId { get; set; }
        public float Rate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}