using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentMe.Models;

namespace RentMe.Controllers
{
    public partial class CarsController : Controller
    {
        // GET: Cars
        public virtual ActionResult Index()
        {
            var car = new CarGroup()
            {
                Brand = "Honda",
                Model = "Jazz"
            };
            return View(car);
        }
    }
}