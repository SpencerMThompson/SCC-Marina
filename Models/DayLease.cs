using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SCC_Marina.Models
{
    public class DayLease : Lease

    {
        public int NumberOfDays { get; set; }

        public DayLease(int numberOfDays)
        {
            NumberOfDays = numberOfDays;
        }

        public DayLease()
        {
        }
    }
}