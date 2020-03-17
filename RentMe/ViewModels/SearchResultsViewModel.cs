using RentMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentMe.ViewModels
{
    public class SearchResultsViewModel
    {
        public IEnumerable<CarGroup> CarGroups { get; set; }

        public DateTime PickupDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}