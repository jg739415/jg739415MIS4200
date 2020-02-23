using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jg739415MIS4200.Models
{
    public class Owner
    {
        public int ownerId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Owner first name required")]
        [StringLength(20)]
        public string ownerFirstName { get; set; }
        
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Owner last name required")]
        [StringLength(20)]
        public string ownerLastName { get; set; }
        [Display(Name = "Email")]
        [Required]
        [EmailAddress(ErrorMessage ="Please enter most used email")]
        public string email { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage = "Phone number must be in format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        [Display(Name = "Date Vehicle Purchased")]
        public DateTime ownerSince { get; set; }

        [Display(Name = "Owner Name")]
        public string ownerName
        {
            get { return ownerLastName + ", " + ownerFirstName; }
        }

    }
}