using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        public ApplicationUser User { get; set; }

    }
}