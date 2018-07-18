using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }

        [Display(Name = "Name Of Restaurant")]
        public string RestaurantName { get; set; }

        [Display(Name = "Cuisine")]
        public string Cuisine { get; set; }

        [Display(Name = "Total Rating")]
        public string TotalRating { get; set; }


    }
}