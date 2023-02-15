using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCC_Marina.Models
{
    public class Slip
    {
        [Key]
        public int SlipID { get; set; }

        public int DockID { get; set; }

        [Required(ErrorMessage = "Please provide the width of the slip")]
        [StringLength(10, ErrorMessage = "Width can't be longer than 10 characters")]
        [DisplayName("Width of Slip")]
        public string Width { get; set; }

        [Required(ErrorMessage = "Please provide the length of the slip")]
        [StringLength(10, ErrorMessage = "Length can't be longer than 10 characters")]
        [DisplayName("Length of Slip")]
        public string SlipLength { get; set; }

        public Slip()
        {

        }

        public Slip(int dockID, int slipID, string width, string slipLength)
        {
            DockID = dockID;
            SlipID = slipID;
            Width = width;
            SlipLength = slipLength;
        }
    }
}