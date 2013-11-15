using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.API.Model.ExtensionMethods
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string str)
        {
            return (String.IsNullOrEmpty(str));
        }

        public static bool IsEqualNoCase(this string str, string compareTo)
        {
            return (String.Compare(str, compareTo, System.StringComparison.OrdinalIgnoreCase) == 0);
        }

        public static bool IsEqualWithCase(this string str, string compareTo)
        {
            return (String.CompareOrdinal(str, compareTo) == 0);
        }
    }
}
