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
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int ExtraFeaturesId { get; set; }
        public ExtraFeature ExtraFeature { get; set; }
        public string Barcode { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
