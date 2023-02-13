using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class Dock
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the dock location.")]
        [DisplayName("Location")]
        [StringLength(50, ErrorMessage = "Dock location cannot have more than 50 characters")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Please choose one")]
        [DisplayName("Does the dock have electricity?")]
        public bool Electricity { get; set; }

        [Required(ErrorMessage = "Please Choose one")]
        [DisplayName("Does the dock have water?")]
        public bool Water { get; set; }
    }
}