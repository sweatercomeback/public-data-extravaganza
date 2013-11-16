using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PD.API.Model.DB;
using PD.API.Model.WS;
using ServiceStack.OrmLite;

namespace PD.API.Model.ExtensionMethods
{
    public static class ModelExtensions
    {
        public static LocationOfInterest DbToWs(this LocationOfInterestDB loiDB, IDbConnection db)
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
            var tyepOfWorkDB = db.Select<TypeOfWorkDB>(m => m.TypeOfWorkID == loiDB.TypeOfWorkID);
            loi.TypeOfWorkDescription = tyepOfWorkDB[0].Description;
            loi.StateCreated = loiDB.StateCreated;
            loi.StartDate = loiDB.StartDate;
            loi.StopDate = loiDB.StopDate;
            loi.CreatedOn = loiDB.CreatedOn;
            return(loi);
        }

        public static TypeOfWork DbToWs(this TypeOfWorkDB typeOfWorkDB)
        {
            Mapper.CreateMap<TypeOfWorkDB, TypeOfWork>();
            return (Mapper.Map<TypeOfWorkDB, TypeOfWork>(typeOfWorkDB));
        }

        public static List<LocationOfInterest> DbToWs(this List<LocationOfInterestDB> locationsOfInterestDB, IDbConnection db)
        {
            var lois = new List<LocationOfInterest>();
            foreach (var loiDB in locationsOfInterestDB)
            {
                var loi = loiDB.DbToWs(db);
                lois.Add(loi);
            }
            return (lois);
        }
    }
}
