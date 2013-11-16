using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PD.API.SODA
{
    public class Row : Dictionary<string, object> 
    {
        public Row() { }
        public Row(Dictionary<string,object> dictionary) : base(dictionary) { }
    }
}
