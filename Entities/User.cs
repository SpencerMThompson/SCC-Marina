using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCC_Marina.Entities
{
    public class User : EntityBase<int>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}