using System.Collections.Generic;
using ServiceStack.ServiceHost;

namespace PD.API.Model
{
    [Api("GET or POST a reset command to the server.")]
    [Route("/Reset", "GET, POST")]
    [Route("/Reset/{ResetKey}", "GET, POST")]
    public class ResetRequest : IReturn<ResetReturn>
    {
        public string ResetKey { get; set; }
    }

    public class ResetReturn
    {
        public List<string> OperationLog { get; set; }
    }
}
