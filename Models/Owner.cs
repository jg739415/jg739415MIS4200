using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jg739415MIS4200.Models
{
    public class Owner
    {
        public int ownerId { get; set; }
        public string ownerFirstName { get; set; }
        public string ownerLastName { get; set; }
        public string email { get; set; }

        public string phone { get; set; }
        public DateTime ownerSince { get; set; }

        public string ownerName
        {
            get { return ownerLastName + ", " + ownerFirstName; }
        }

    }
}