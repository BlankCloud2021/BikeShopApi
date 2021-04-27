using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BikeShopApi.Models
{
    public class BikeShopApiDbContext: DbContext
    {
        public BikeShopApiDbContext(DbContextOptions<BikeShopApiDbContext> options) 
            : base(options) { }


       public DbSet<Bike> Bikes { get; set; }
        public DbSet<BikeShop> BikeShops { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<ExtraFeature> ExtraFeatures { get; set; }
        public DbSet<Location>Locations{ get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
       

    }
}
