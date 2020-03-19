using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentMe.Models;

namespace RentMe.ViewModels
{
    public class RentClientDetailsViewModel
    {
        public Client Client { get; set; }
        public RentDetailsViewModel RentDetailsViewModel { get; set; }
    }
}