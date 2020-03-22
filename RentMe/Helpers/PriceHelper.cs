using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentMe.Helpers
{
    public static class PriceHelper
    {
        public static float Calculate(DateTime pickupDate, DateTime returnDate, float dayPrice)
        {
            return Convert.ToInt32(Math.Ceiling((returnDate - pickupDate).TotalDays)) * dayPrice;
        }
    }
}