using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    public static class StringExtension
    {
        public static string Truncate(this string value, int maxChars)
        {
            if (value.Length <= maxChars)
            {
                return value;
            }
            else
            {
                return value.Substring(0, maxChars) + "...";
            }
        }
    }
}
