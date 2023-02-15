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
        [DisplayName("Width of Slip")]
        public string Width { get; set; }

        [Required(ErrorMessage = "Please provide the length of the slip")]
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