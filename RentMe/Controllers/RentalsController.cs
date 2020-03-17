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
        public virtual ActionResult SearchResult(DateTime pickupDate, DateTime returnDate)
        {
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

            var viewModel = new SearchResultsViewModel()
            {
                CarGroups = resultCarGroups,
                PickupDate = pickupDate,
                ReturnDate = returnDate,
            };

            return View(MVC.Rentals.Views.SearchResult, viewModel);
        }

        public virtual ActionResult RentDetails(DateTime pickupDate, DateTime returnDate, int carGroupId)
        {
            var carGroup = context.CarGroups.First(g => g.Id == carGroupId);
            var viewModel = new RentDetailsViewModel()
            {
                PickupDate = pickupDate,
                ReturnDate = returnDate,
                CarGroup = carGroup,
            };
            return View(MVC.Rentals.Views.RentDetails, viewModel);
        }

        public ActionResult UserDetails(DateTime pickupDate, DateTime returnDate, int carGroupId)
        {
            return View();
        }

        public virtual ActionResult New(DateTime pickupDate, DateTime returnDate, int carGroupId)
        {
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
                ReturnDate = returnDate
            };

            context.Rentals.Add(newRental);
            context.SaveChanges();

            return View(MVC.Rentals.Views.Successful);
        }
    }
}