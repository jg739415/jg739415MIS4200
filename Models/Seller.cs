using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jg739415MIS4200.Models
{
    public class Seller
    {
        public int sellerId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Seller first name required")]
        public string sellerFirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Seller last name required")]
        public string sellerLastName { get; set; }

        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "(0:MM/dd/yyyy)", ApplyFormatInEditMode =true)]
        public DateTime employeeSince { get; set; }
        public ICollection<VehicleDetails> VehicleDetails { get; set; }
        
        [Display(Name = "Seller Name")]
        [Required(ErrorMessage = "Seller name required")]
        public string sellerName
        {
            get { return sellerLastName + ", " + sellerFirstName; }
        }
    }
}