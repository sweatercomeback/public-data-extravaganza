using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PD.API.Model;
using PD.API.Model.DB;
using PD.API.Model.ExtensionMethods;
using PD.API.Model.WS;
using PD.API.Services.Filters;
using PD.API.Services.Helpers;
using ServiceStack.OrmLite;
using ServiceStack.ServiceInterface;
using LocationOfInterest = PD.API.Model.DB.LocationOfInterestDB;

namespace PD.API.Services
{
    [RecordRequestFilter(ServiceName)]
    [RecordResponseFilter(ServiceName)]
    public class WorkRequestService : Service
    {
        public const string ServiceName = "Work Request Service";

        public IDbConnectionFactory DbConnectionFactory { get; set; }

        /// <summary>
        /// Gets the website configuration settings relevant to services. The built-in IoC used with ServiceStack autowires this property.
        /// </summary>
        public SiteConfig Config { get; set; }

        /// <summary>
        /// Current logger defined for the application. The built-in IoC used with ServiceStack autowires this property.
        /// </summary>
        public LogHelper LogHelper { get; set; }

        #region Public API Methods

        public List<LocationOfInterest> Any(LocationOfInterestListRequest request)
        {
            List<LocationOfInterestDB> locationsOfInterest;

            using (var db = DbConnectionFactory.OpenDbConnection())
            {
                locationsOfInterest = db.Select<LocationOfInterestDB>();
            }
            return locationsOfInterest;
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
