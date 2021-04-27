using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShopApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int BikeId { get; set; }
        public Bike Bike { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ReturnByDate { get; set; }
        public DateTime ReturnedOnDate { get; set; }
        public int ResrvationId { get; set; }
        public Reservation Reservation { get; set; }

    }
}
