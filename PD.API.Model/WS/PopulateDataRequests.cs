using System.Collections.Generic;
using ServiceStack.ServiceHost;

namespace PD.API.Model
{
    [Api("GET or POST a reset command to the server.")]
    [Route("/PopulateData", "GET, POST")]
    [Route("/PopulateData/{PopulateKey}", "GET, POST")]
    public class PopulateDataRequest : IReturn<PopulateDataReturn>
    {
        public string PopulateKey { get; set; }
    }

    public class PopulateDataReturn
    {
        public List<string> OperationLog { get; set; }
    }
}
