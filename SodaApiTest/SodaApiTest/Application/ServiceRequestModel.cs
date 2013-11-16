using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodaApiTest.Application
{
    public class ServiceRequestModel
    {
        public string ServNo { get; set; }
        public DateTime RequestDate { get; set; }
        public string ProbCode { get; set; }
        public string ProbDesc { get; set; }
        public string Assigned { get; set; }
        public string Location { get; set; }
        public string AddressType { get; set; }
        public string Address { get; set; }
        public float GPSX { get; set; }
        public float GPSY { get; set; }

    }
}