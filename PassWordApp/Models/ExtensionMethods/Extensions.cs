using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace PassWordApp.Models.ExtensionMethods
{
    public static class Extensions
    {
        public static PassWord CopyTo(this PassWord src, PassWord dst)
        {
            dst.PassWordId = src.PassWordId;
            dst.PassWordKey = src.PassWordKey;
            dst.PassWordValue = src.PassWordValue;
            dst.Note = src.Note;

            return dst;
        }
    }
}