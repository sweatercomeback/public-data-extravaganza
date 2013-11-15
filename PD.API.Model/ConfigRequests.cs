using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.ServiceHost;

namespace PD.API.Model
{
    [Api("GET the configuration options from the server.")]
    [Route("/Config", "GET")]
    public class ConfigOptionsRequest : IReturn<ConfigOptionsResult> {}

    public class ConfigOptionsResult
    {
        public string ClientIPAddress { get; set; }
        public string OAuthURL { get; set; }
        public string AppID { get; set; }
        public string FullVersion { get; set; }
    }

    [Api("Get version information from the server.")]
    [Route("/Ping", "GET")]
    [Route("/Ping/{MSTimeBeforeResponse}", "GET")]
    public class PingRequest
    {
        public int MSTimeBeforeResponse { get; set; }
#if DEBUG
        public bool ThrowException { get; set; }
#endif
    }

    public class PingResponse
    {
        public string FullVersion { get; set; }
    }
}
