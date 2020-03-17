using System;
using System.ComponentModel.DataAnnotations;

namespace RentMe.ViewModels
{
    public class SearchViewModel
    {
        [Display(Name = "Pickup Date")]
        public DateTime PickupDate { get; set; }

        [Display(Name = "Return Date")]
        public DateTime ReturnDate { get; set; }
    }
}