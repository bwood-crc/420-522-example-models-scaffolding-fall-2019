using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PassWordApp.Models
{
    public static class DB
    {
        public static int LastId = 1;

        public static List<PassWord> passWordList = new List<PassWord>();
    }
}