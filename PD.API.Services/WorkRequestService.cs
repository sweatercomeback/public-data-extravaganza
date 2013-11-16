using System;
using System.Collections.Generic;
using System.Reflection;
using PD.API.Model.DB;
using PD.API.Model.ExtensionMethods;
using PD.API.Model.WS;
using PD.API.Services.Filters;
using PD.API.Services.Helpers;
using ServiceStack.OrmLite;
using ServiceStack.ServiceInterface;

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

        public List<LocationOfInterest> Get(LocationOfInterestListRequest request)
        {
            List<LocationOfInterestDB> locationsOfInterestDB;

            using (var db = DbConnectionFactory.OpenDbConnection())
            {
                locationsOfInterestDB = db.Select<LocationOfInterestDB>();
            }

            List<LocationOfInterest> ret = locationsOfInterestDB.DbToWs();
            return ret;
        }

        public LocationOfInterest Get(LocationOfInterestRequest request)
        {
            LocationOfInterest locationOfInterest = null;

            using (var db = DbConnectionFactory.OpenDbConnection())
            {
                var array = db.Select<LocationOfInterestDB>(m => m.ID == request.ID);
                if (array.Count == 1)
                {
                    locationOfInterest = array[0].DbToWs();
                }
            }
            return locationOfInterest;
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
