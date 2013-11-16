using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PD.API.Model;
using PD.API.Model.ExtensionMethods;
using PD.API.Services.Filters;
using PD.API.Services.Helpers;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace PD.API.Services
{
    [RecordRequestFilter(ServiceName)]
    [RecordResponseFilter(ServiceName)]
    public class ConfigService : Service
    {
        public const string ServiceName = "Config Service";
        public const string AppName = "IL PublicData API";


        /// <summary>
        /// Gets the website configuration settings relevant to services. The built-in IoC used with ServiceStack autowires this property.
        /// </summary>
        public SiteConfig Config { get; set; }

        /// <summary>
        /// Current logger defined for the application. The built-in IoC used with ServiceStack autowires this property.
        /// </summary>
        public LogHelper LogHelper { get; set; } 

        #region Public API Methods

        public PingResponse Any(PingRequest request)
        {
            if (request.MSTimeBeforeResponse != 0)
            {
                Thread.Sleep(request.MSTimeBeforeResponse);
            }
#if DEBUG
            if (request.ThrowException)
            {
                throw new Exception("Forced exception.");
            }
#endif
            var versionResponse = new PingResponse { FullVersion = GetApplicationVersion() };
            return (versionResponse);
        }
        
        public ConfigOptionsResult Any(ConfigOptionsRequest request)
        {
            return (new ConfigOptionsResult()
            {
                ClientIPAddress = IpToProperIp(base.Request.RemoteIp),
                OAuthURL = Config.OAuthURL,
                AppID = Config.AppID,
                FullVersion = GetApplicationVersion()
            });
        }
        
        #endregion

        #region Private Helper Methods
        
        public static string GetApplicationVersion()
        {
            var ver = Assembly.GetExecutingAssembly().GetName().Version;
            return (ver.ToString());
        }

        public static string IpToProperIp(string ip)
        {
            return ((String.CompareOrdinal(ip, "::1") == 0) ? "127.0.0.1" : ip);
        }

        #endregion
    }
}
