using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentMe.Models;

namespace RentMe.ViewModels
{
    public class RentDetailsViewModel
    {
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int CarGroupId { get; set; }
    }
}