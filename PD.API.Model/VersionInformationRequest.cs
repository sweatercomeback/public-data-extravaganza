using ServiceStack.ServiceHost;

namespace PD.API.Model
{
    [Route("/VersionInformation", "GET, POST")]
    public class VersionInformationRequest
    {
        public int MSTimeBeforeResponse { get; set; }
#if DEBUG
        public bool ThrowException { get; set; }
#endif
    }

    public class VersionInformationResponse
    {
        public string FullVersion { get; set; }
    }
}
