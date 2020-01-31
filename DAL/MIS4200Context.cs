﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using jg739415MIS4200.Models;

namespace jg739415MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            
        }

        public DbSet<customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}