using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IIW.Models.ProjectModels
{
    public class Movies
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieTheaterName { get; set; }
        public string MovieTheaterAddress { get; set; }
        public string MovieName { get; set; }
        public string MovieShowTimes { get; set; }
    }
}