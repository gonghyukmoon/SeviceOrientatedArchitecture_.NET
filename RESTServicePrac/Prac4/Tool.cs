using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prac4
{
    public static class Tool
    {
        public static string ToStr(this string str)
        {
            return str.Replace(",", " ");
        }
    }
}