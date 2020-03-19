using System.ComponentModel.DataAnnotations;
using RentMe.ViewModels;

namespace RentMe.Models.ValidationAttributes
{
    public class CheckIfDateReturnIsLaterThanPickup : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var viewModel = (SearchViewModel)validationContext.ObjectInstance;

            if (viewModel.PickupDate >= viewModel.ReturnDate)
            {
                return new ValidationResult("Return Date should be later than Pickup Date.");
            }

            return ValidationResult.Success;

        }
    }
}