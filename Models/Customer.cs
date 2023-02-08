using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address{ get; set; }
        public string Phone { get; set; }
    }
}