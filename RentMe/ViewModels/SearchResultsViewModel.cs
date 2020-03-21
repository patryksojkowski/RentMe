using RentMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentMe.ViewModels
{
    public class SearchResultsViewModel
    {
        public SearchResultsViewModel(IEnumerable<CarGroup> carGroups, DateTime pickupDate, DateTime returnDate)
        {
            CarGroups = carGroups;
            PickupDate = pickupDate;
            ReturnDate = returnDate;
            RentalPeriodInDays = Convert.ToInt32(Math.Ceiling((returnDate - pickupDate).TotalDays));
        }
        public IEnumerable<CarGroup> CarGroups { get; set; }

        public DateTime PickupDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public int RentalPeriodInDays { get; set; }
    }
}