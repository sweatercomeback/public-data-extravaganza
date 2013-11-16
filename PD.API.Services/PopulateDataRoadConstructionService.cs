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
    public class PopulateDataRoadConstructionService : Service
    {
        public const string ServiceName = "Populate Data Road Construction Service";

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

        public PopulateDataReturn Get(PopulateDataRoadConstructionRequest request)
        {
            var returnLog = new PopulateDataReturn();

            returnLog.OperationLog = new List<string>();

            returnLog.OperationLog.Add("Populate Data started on " + DateTime.Now.ToShortTimeString() + ".");

            var hostId = Config.SodaHost;
            var dataSetId = Config.SodaDataSet;

            if (request.PopulateKey.IsEqualWithCase("PrettyPleasePopulateTheSystem"))
            {
                using (var db = DbConnectionFactory.OpenDbConnection())
                {
                    returnLog.OperationLog.Add("Populating TypeOfWork Table.");

                    //db.Insert(new TypeOfWork() { Description = "Road Construction"});
                    //db.Insert(new TypeOfWork() { Description = "Pot Hole" });


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
