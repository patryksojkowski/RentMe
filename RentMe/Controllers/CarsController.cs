using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentMe.Models;

namespace RentMe.Controllers
{
    public partial class CarsController : Controller
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }

        // GET: Cars
        public virtual ActionResult Index()
        {
            var groups = context.CarGroups.Include(c => c.CarGroupDetails).AsEnumerable();

            return View(groups);
        }

        public virtual ActionResult Details(int id)
        {
            return Content(id.ToString());
        }


    }
}