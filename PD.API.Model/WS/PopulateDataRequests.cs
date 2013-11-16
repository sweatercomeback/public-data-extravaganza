using System.Collections.Generic;
using ServiceStack.ServiceHost;

namespace PD.API.Model
{
    [Api("GET or POST a reset command to the server.")]
    [Route("/PopulateDataRoadConstruction", "GET")]
    [Route("/PopulateDataRoadConstruction/{PopulateKey}", "GET")]
    public class PopulateDataRoadConstructionRequest : IReturn<PopulateDataReturn>
    {
        public string PopulateKey { get; set; }
    }

    [Api("GET or POST a reset command to the server.")]
    [Route("/PopulateDataServiceRequest", "GET, POST")]
    [Route("/PopulateDataServiceRequest/{PopulateKey}", "GET, POST")]
    public class PopulateDataServiceRequest : IReturn<PopulateDataReturn>
    {
        public string PopulateKey { get; set; }
    }

    public class PopulateDataReturn
    {
        public List<string> OperationLog { get; set; }
    }
}
