using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.API.Model.ExtensionMethods
{
    public static class GuidExtensions
    {
        public static bool IsEmpty(this Guid guid)
        {
            return (Guid.Empty.CompareTo(guid) == 0);
        }
    }
}
