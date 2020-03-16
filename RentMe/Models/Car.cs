using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RentMe.Models
{
    public class Car
    {
        [Required]
        public int Id { get; set; }

        public CarGroup CarGroup { get; set; }
        public int CarGroupId { get; set; }
    }
}