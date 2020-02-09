using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using jg739415MIS4200.Models;

namespace jg739415MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, jg739415MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet<customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }

        public DbSet<Products> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        
        public DbSet<Owner> Owners { get; set; }
        public DbSet<VehicleDetails> VehicleDetails { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Seller> Sellers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

        //public System.Data.Entity.DbSet<jg739415MIS4200.Models.Owner> Owners { get; set; }

        //public System.Data.Entity.DbSet<jg739415MIS4200.Models.VehicleDetails> VehicleDetails { get; set; }

        //public System.Data.Entity.DbSet<jg739415MIS4200.Models.Seller> Sellers { get; set; }

        //public System.Data.Entity.DbSet<jg739415MIS4200.Models.Vehicle> Vehicles { get; set; }
    }
}