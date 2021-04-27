using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShopApi.Models
{
    public class ExtraFeature
    {
      public int Id { get; set; }   
        public string Feature { get; set;  }
        public ICollection<Bike> Bikes { get; set; }
    }
}
