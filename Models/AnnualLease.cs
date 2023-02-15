using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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

        [DisplayName("Monthly Payment Due Date")]
        public DateTime MonthlyPaymentDate { get; set; }

        [DisplayName("Balance Remaining")]
        public float RemainingBalance { get; set; }
    }
}