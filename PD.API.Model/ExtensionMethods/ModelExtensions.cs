using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PD.API.Model.DB;
using PD.API.Model.WS;

namespace PD.API.Model.ExtensionMethods
{
    public static class ModelExtensions
    {
        public static LocationOfInterest DbToWs(this LocationOfInterestDB loiDB)
        {
            var loi = new LocationOfInterest();
            loi.LocationOfInterestID = loiDB.LocationOfInterestID;
            loi.LocationDescription = loiDB.LocationDescription;
            loi.DescriptionOfWork = loiDB.DescriptionOfWork;
            loi.Position = new Position();
            loi.Position.Latitutde = loiDB.PositionLatitutde;
            loi.Position.Longitude = loiDB.PositionLongitude;
            if (loiDB.PovHeading != null)
            {
                loi.POV = new PointOfView();
                loi.POV.Heading = loiDB.PovHeading.Value;
                loi.POV.Pitch = loiDB.PovPitch.Value;
            }
            loi.PanoID = loiDB.PanoID;
            loi.UploadedImageIDs = loiDB.UploadedImageIDs;
            loi.TypeOfWorkID = loiDB.TypeOfWorkID;
            loi.StateCreated = loiDB.StateCreated;
            loi.StartDate = loiDB.StartDate;
            loi.StopDate = loiDB.StopDate;
            loi.CreatedOn = loiDB.CreatedOn;
            return(loi);
        }

        public static List<LocationOfInterest> DbToWs(this List<LocationOfInterestDB> locationsOfInterestDB)
        {
            var lois = new List<LocationOfInterest>();
            foreach (var loiDB in locationsOfInterestDB)
            {
                var loi = loiDB.DbToWs();
                lois.Add(loi);
            }
            return (lois);
        }
    }
}
