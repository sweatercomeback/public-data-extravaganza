using System;
using System.Collections.Generic;
using ServiceStack.ServiceHost;

namespace PD.API.Model.WS
{
    [Api("GET all Locations of Interest.")]
    [Route("/LocationsOfInterest", "GET")]
    public class LocationOfInterestListRequest : IReturn<List<LocationOfInterest>> { }

    [Api("GET a Location of Interest.")]
    [Route("/LocationOfInterest", "GET")]
    [Route("/LocationOfInterest", "GET")]
    public class LocationOfInterestRequest : IReturn<LocationOfInterest>
    {
        public int LocationOfInterestID { get; set; }
    }
      
    [Api("PUT, or POST a location of interest.")]
    [Route("/Config", "GET")]
    public class LocationOfInterest : IReturn<LocationOfInterest>
    {
        public int LocationOfInterestID { get; set; }
        public string LocationDescription { get; set; }
        public string DescriptionOfWork { get; set; }
        public Position Position { get; set; }
        public PointOfView POV { get; set; }
        public string PanoID { get; set; }
        public List<int> UploadedImageIDs { get; set; }
        public int TypeOfWorkID { get; set; }
        public bool StateCreated { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StopDate { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    public class Position
    {
        public double Latitutde { get; set; }
        public double Longitude { get; set; }
    }

    public class PointOfView
    {
        public double Heading { get; set; }
        public double Pitch { get; set; }
    }


}
