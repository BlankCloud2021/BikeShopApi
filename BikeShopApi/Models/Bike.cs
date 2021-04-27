using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShopApi.Models
{
    public class Bike
    {
        public int Id { get; set; }
        public float FrameSize { get; set; }
        public int HomeStoreId { get; set; }
        public BikeShop HomeBikeShop { get; set; }
        public int CurrentStoreId { get; set; }
        public BikeShop BikeShopLocation { get; set; }
        public int ExtraFeaturesId { get; set; }
        public ExtraFeature ExtraFeature { get; set; }
        public string Barcode { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; } 
        public bool OnHire { get; set; }
        public int OnHireCustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
