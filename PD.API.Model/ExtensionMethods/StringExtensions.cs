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
    }
}
