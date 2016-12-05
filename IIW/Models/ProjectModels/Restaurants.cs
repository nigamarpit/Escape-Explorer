using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IIW.Models.ProjectModels
{
    public class Restaurants
    {
        [Key]
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantAddress { get; set; }
        public string RestaurantRating { get; set; }
        public string RestaurantCuisine { get; set; }
        public string RestaurantTelephone { get; set; }
        public string RestaurantImage { get; set; }
    }
}