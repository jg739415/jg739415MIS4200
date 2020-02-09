using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jg739415MIS4200.Models
{
    public class VehicleDetails
    {
        public int vehicleDetailsID { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public string vehicleID { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public int sellerID { get; set; }
        public virtual Seller Seller { get; set; }
    }
}