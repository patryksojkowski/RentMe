using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RentMe.Models
{
    public class CarGroup
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }
        
        [Required]
        public string Model { get; set; }

        [Required]
        public float DayPrice { get; set; }
    }
}