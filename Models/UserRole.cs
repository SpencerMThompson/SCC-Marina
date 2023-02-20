using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class UserRole
    {
        [Key]
        public int UserRoleID { get; set; }
        public string UserId { get; set; }
        public int RoleId { get; set; }
    }
}