using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class Slip
    {
        public int DockID { get; set; }

        public int SlipID { get; set; }

        public string Width { get; set; }

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