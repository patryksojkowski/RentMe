using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentMe.Models
{
    public class CarGroupDetails
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int NumberOfSeats { get; set; }

        [Required]
        public int NumberOfDoors { get; set; }

        [Required]
        public int NumberOfLargeBags { get; set; }

        [Required]
        public bool IsAC { get; set; }

        [Required]
        public string Transmission { get; set; }

        [Required]
        public string PhotoUrl { get; set; }
    }
}