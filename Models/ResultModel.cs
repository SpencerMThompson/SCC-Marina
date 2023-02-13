using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCC_Marina.Models
{
    public class ResultModel
    {
        public bool IsSuccessful { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }
    }
}