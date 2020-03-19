using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using RentMe.Models;
using RentMe.ViewModels;

namespace RentMe.Controllers
{
    public partial class RentalsController : Controller
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }

        // GET: Rentals
        public virtual ActionResult SearchResult(SearchViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(MVC.Home.Views.Index, viewModel);
            }

            var returnDate = viewModel.ReturnDate;
            var pickupDate = viewModel.PickupDate;

            var cars = context.Cars.Include(car => car.CarGroup).AsEnumerable();
            var rentals = context.Rentals.AsEnumerable();

            foreach(var rental in rentals)
            {
                if (rental.PickupDate < returnDate && pickupDate < rental.ReturnDate)
                {
                    cars = cars.Where(car => car.Id != rental.CarId);
                }
            }

            var resultCarGroups = new List<CarGroup>();

            foreach(var car in cars)
            {
                resultCarGroups.Add(car.CarGroup);
            }
            resultCarGroups = resultCarGroups.Distinct().ToList();

            var searchResultsModel = new SearchResultsViewModel()
            {
                CarGroups = resultCarGroups,
                PickupDate = pickupDate,
                ReturnDate = returnDate,
            };

            return View(MVC.Rentals.Views.SearchResult, searchResultsModel);
        }

        public virtual ActionResult RentDetails(DateTime pickupDate, DateTime returnDate, int carGroupId)
        {
            var viewModel = new RentDetailsViewModel()
            {
                PickupDate = pickupDate,
                ReturnDate = returnDate,
                CarGroupId = carGroupId,
            };
            return View(MVC.Rentals.Views.RentDetails, viewModel);
        }

        public virtual ActionResult ClientDetails(DateTime pickupDate, DateTime returnDate, int carGroupId)
        {
            var client = new Client();

            var viewModel = new RentClientDetailsViewModel()
            {
                Client = client,
                RentDetailsViewModel = new RentDetailsViewModel
                {
                    PickupDate = pickupDate,
                    ReturnDate = returnDate,
                    CarGroupId = carGroupId
                },
            };
            return View(MVC.Rentals.Views.ClientDetails, viewModel);
        }

        public virtual ActionResult New(RentClientDetailsViewModel viewModel)
        {
            var carGroupId = viewModel.RentDetailsViewModel.CarGroupId;
            var pickupDate = viewModel.RentDetailsViewModel.PickupDate;
            var returnDate = viewModel.RentDetailsViewModel.ReturnDate;
            var client = viewModel.Client;

            var carsFromGroup = context.Cars.Where(c => c.CarGroupId == carGroupId);

            var rentalsFromGroup = context.Rentals.Where(r => carsFromGroup.Select(c => c.Id).Contains(r.CarId));

            var availableCars = carsFromGroup;

            foreach (var rental in rentalsFromGroup)
            {
                if (rental.PickupDate <= returnDate && pickupDate <= rental.ReturnDate)
                {
                    availableCars = availableCars.Where(c => c.Id != rental.CarId);
                }
            }

            var car = availableCars.First();

            var newRental = new Rental()
            {
                Car = car,
                PickupDate = pickupDate,
                ReturnDate = returnDate,
                Client = client,
            };

            context.Rentals.Add(newRental);
            context.SaveChanges();

            return View(MVC.Rentals.Views.Successful);
        }
    }
}