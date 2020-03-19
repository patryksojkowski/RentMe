using System;
using System.ComponentModel.DataAnnotations;
using RentMe.Models.ValidationAttributes;

namespace RentMe.ViewModels
{
    [CheckIfDateReturnIsLaterThanPickup]
    public class SearchViewModel
    {
        [Display(Name = "Pickup Date")]
        public DateTime PickupDate { get; set; }

        [Display(Name = "Return Date")]
        public DateTime ReturnDate { get; set; }
    }
}