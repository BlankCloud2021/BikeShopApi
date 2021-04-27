using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShopApi.Models
{
    public class BikeShop
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
   
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
