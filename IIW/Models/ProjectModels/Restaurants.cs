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
        public string Cuisines { get; set; }
        public string Establishment_types { get; set; }
        public string currency { get; set; }
        public string featured_image { get; set; }
        public string average_cost_for_two { get; set; }
        public string deeplink { get; set; }
        public string thumb { get; set; }
        public string is_delivering_now { get; set; }
        public string menu_url { get; set; }
        public string photos_url { get; set; }
        public string user_rating { get; set; }
        public string offers { get; set; }
        public string location { get; set; }
        public string has_table_booking { get; set; }
        public string events_url { get; set; }
        public string price_range { get; set; }
        public string name { get; set; }
        public string has_online_delivery { get; set; }
        public string url { get; set; }
    }
}