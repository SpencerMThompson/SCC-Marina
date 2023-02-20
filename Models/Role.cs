using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        
        [Required(ErrorMessage = "Please add role name")]
        [DisplayName("Role Name")]
        public string RoleName { get; set; }
    }
}