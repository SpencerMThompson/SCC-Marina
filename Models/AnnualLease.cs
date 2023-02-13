using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SCC_Marina.Models
{
    public class AnnualLease : Lease
    {
        public AnnualLease(DateTime monthlyPaymentDate, float remainingBalance)
        {
            MonthlyPaymentDate = monthlyPaymentDate;
            RemainingBalance = remainingBalance;
        }

        public AnnualLease()
        {
        }

        public DateTime MonthlyPaymentDate { get; set; }
        public float RemainingBalance { get; set; }
    }
}