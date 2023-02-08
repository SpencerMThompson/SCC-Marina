using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class AnnualLease : Lease
    {
        public DateTime MonthlyPaymentDate { get; set; }
        public float RemainingBalance { get; set; }
    }
}