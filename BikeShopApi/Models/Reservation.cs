using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShopApi.Models
{
    public class Reservation
    {
        public int Id { get; set; } 
        public int CurrentLocationId { get; set; }
        public BikeShop CurrentBikeShop { get; set; }
        public int PickUpLocationId { get; set; }
        public BikeShop PickUpBikeShop { get; set; }
        public DateTime PickUpdate { get; set; }
    }
}
