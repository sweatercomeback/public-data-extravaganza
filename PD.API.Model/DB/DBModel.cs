using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ServiceStack.DataAnnotations;

namespace PD.API.Model.DB
{
    [Alias("Users")]
    public class UserDB
    {
        [AutoIncrement]
        public int UserID { get; set; }
        [Index(true)]
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(12)]
        public string Phone { get; set; }
        [StringLength(150)]
        public string EmailAddress { get; set; }
        [References(typeof(AddressDB))]
        public int HomeAddressID { get; set; }
        public List<int> LocationsOfIntereset { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    [Alias("Addresses")]
    public class AddressDB
    {
        [AutoIncrement]
        public int AddressID { get; set; }
        [StringLength(50)]
        public string Address1 { get; set; }
        [StringLength(50)]
        public string Address2 { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [Index(false)]
        [StringLength(20)]
        public string Zip { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    [Alias("LocationsOfInterest")]
    public class LocationOfInterestDB
    {
        [AutoIncrement]
        public int LocationOfInterestID { get; set; }
        [StringLength(500)]
        public string LocationDescription { get; set; }
        public string DescriptionOfWork { get; set; }
        public double PositionLatitutde { get; set; }
        public double PositionLongitude { get; set; }
        public double? PovHeading { get; set; }
        public double? PovPitch { get; set; }
        [StringLength(50)]
        public string PanoID { get; set; }
        public List<int> UploadedImageIDs { get; set; }
        [References(typeof(TypeOfWorkDB))]
        public int TypeOfWorkID { get; set; }
        public bool StateCreated { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StopDate { get; set; }
        public int UpVote { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    [Alias("ImagesOfInterest")]
    public class ImageOfInterestDB
    {
        [AutoIncrement]
        public int ImageOfInterestID { get; set; }
        public string Description { get; set; }
        [StringLength(5)]
        public string FileType { get; set; }
        public DateTime CreatedOn { get; set; }
    }


    public class TypeOfWorkDB
    {
        [AutoIncrement]
        public int TypeOfWorkID { get; set; }
        [StringLength(20)]
        public string Description { get; set; }
    }
}
