using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentMe.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public Car Car { get; set; }
        public int CarId { get; set; }

        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}