using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShopApi.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int BikeShopId { get; set; } 
        public BikeShop BikeShop { get; set; }

    }
}
