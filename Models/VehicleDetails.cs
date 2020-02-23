using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jg739415MIS4200.Models
{
    public class VehicleDetails
    {
        public int vehicleDetailsID { get; set; }
        
        [Display(Name = "Make")]
        [Required(ErrorMessage ="Required")]
        public string make { get; set; }

        [Display(Name = "Model")]
        [Required(ErrorMessage = "Required")]
        public string model { get; set; }
        
        [Display(Name = "Year")]
        [Required]
        [StringLength(4)]
        public string year { get; set; }
        public string vehicleID { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        [Display(Name = "Seller Name")]
        [Required(ErrorMessage ="Seller name required")]
        public int sellerID { get; set; }
        public virtual Seller Seller { get; set; }
    }
}