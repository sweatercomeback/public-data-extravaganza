using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace PD.API.Model.DB
{
    [Alias("Users")]
    public class User
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
        [References(typeof(Address))]
        public int HomeAddressID { get; set; }
        [References(typeof(Address))]
        public int WorkAddressID { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    [Alias("Addresses")]
    public class Address
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
}
