using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jg739415MIS4200.Models
{
    public class Vehicle
    {
        [Key]
        public int vehicleID { get; set; }
        public DateTime datePurchased { get; set; }

        public ICollection<VehicleDetails> VehicleDetails { get; set; }

        public int ownerId { get; set; }
        public virtual Owner Owner { get; set; }
    }
}