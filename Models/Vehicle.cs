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

        [Display(Name = "Date Purchased")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "(0:MM/dd/yyyy)", ApplyFormatInEditMode = true)]
        public DateTime datePurchased { get; set; }

        [Display(Name = "Vehicle Details")]

        public ICollection<VehicleDetails> VehicleDetails { get; set; }

        [Display(Name = "Owner Name")]
        [Required(ErrorMessage = "Owner name required")]
        public int ownerId { get; set; }
        public virtual Owner Owner { get; set; }
    }
}