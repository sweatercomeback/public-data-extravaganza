using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PD.API.Model;
using PD.API.Model.DB;
using PD.API.Model.ExtensionMethods;
using PD.API.Services.Filters;
using PD.API.Services.Helpers;
using ServiceStack.OrmLite;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace PD.API.Services
{
    [RecordRequestFilter(ServiceName)]
    [RecordResponseFilter(ServiceName)]
    public class Resetervice : Service
    {
        public const string ServiceName = "Reset Service";

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

        public ResetReturn Any(ResetRequest request)
        {
            var returnLog = new ResetReturn();

            returnLog.OperationLog = new List<string>();

            returnLog.OperationLog.Add("Config reset started on " + DateTime.Now.ToShortTimeString() + ".");

            if (request.ResetKey.IsEqualWithCase("PrettyPleaseResetTheSystemAndDestroyAllData123"))
            {
                using (var db = DbConnectionFactory.OpenDbConnection())
                {
                    db.CreateTable<Address>(true);
                    returnLog.OperationLog.Add("Created Address.");
                    db.CreateTable<TypeOfWork>(true);
                    returnLog.OperationLog.Add("Created TypeOfWork.");
                    db.CreateTable<ImageOfInterest>(true);
                    returnLog.OperationLog.Add("Created ImageOfInterest.");
                    db.CreateTable<LocationOfInterest>(true);
                    returnLog.OperationLog.Add("Created LocationOfInterest.");
                    db.CreateTable<User>(true);
                    returnLog.OperationLog.Add("Created User.");
                }
            }
            else
            {
                returnLog.OperationLog.Add("Invalid Key.");
            }
            return returnLog;
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
