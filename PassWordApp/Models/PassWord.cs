using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PassWordApp.Models
{
    public class PassWord
    {
        public int PassWordId { get; set; }

        public string PassWordKey { get; set; }

        public string PassWordValue { get; set; }

        public string Note { get; set; }
    }
}