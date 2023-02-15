using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class DayLease : Lease

    {
        [Required(ErrorMessage = "Please provide the number of days you are going to stay")]
        [DisplayName("Number of days you're staying")]
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