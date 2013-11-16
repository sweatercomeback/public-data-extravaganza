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
    public class PopulateDataServiceRequestService : Service
    {
        public const string ServiceName = "Populate Data Service Request Service";

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
        
        public PopulateDataReturn Get(PopulateDataServiceRequest request)
        {
            var returnLog = new PopulateDataReturn();

            returnLog.OperationLog = new List<string>();

            returnLog.OperationLog.Add("Populate Data started on " + DateTime.Now.ToShortTimeString() + ".");

            var host = Config.SodaHost;
            var dataSetId = Config.ServiceRequestDataSet;

            var dataSet = PD.API.SODA.ReadDataFromSoda.ServiceRequestData(host, dataSetId);

            if (request.PopulateKey.IsEqualWithCase("PrettyPleasePopulateTheSystem"))
            {
                using (var db = DbConnectionFactory.OpenDbConnection())
                {
                    returnLog.OperationLog.Add("Populating TypeOfWork Table.");

                    db.Insert(new TypeOfWorkDB() { Description = "Service Request" });
                    var types = db.Select<TypeOfWorkDB>(m => m.Description == "Service Request");
                    foreach (var data in dataSet)
                    {
                        var locationOfInterestDB = new LocationOfInterestDB();
                        locationOfInterestDB.PositionLatitutde = 0;
                        locationOfInterestDB.PositionLongitude = 0;
                        locationOfInterestDB.LocationDescription = data.Address;
                        locationOfInterestDB.TypeOfWorkID = types[0].TypeOfWorkID;
                        locationOfInterestDB.StateCreated = false;
                        locationOfInterestDB.DescriptionOfWork = data.ProbDesc;
                        locationOfInterestDB.CreatedOn = data.RequestDate;
                        locationOfInterestDB.StartDate = null;
                        locationOfInterestDB.StopDate = null;
                        locationOfInterestDB.UpVote = 0;
                        db.Insert(locationOfInterestDB);
                        //collection.Add(locationOfInterestDB);
                    }
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
        
        #endregion
    }
}
