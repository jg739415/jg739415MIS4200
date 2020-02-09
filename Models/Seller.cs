using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jg739415MIS4200.Models
{
    public class Seller
    {
        public int sellerId { get; set; }
        public string sellerFirstName { get; set; }
        public string sellerLastName { get; set; }
        public DateTime employeeSince { get; set; }
        public ICollection<VehicleDetails> VehicleDetails { get; set; } 
        public string sellerName
        {
            get { return sellerLastName + ", " + sellerFirstName; }
        }
    }
}