using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IIW.Models.ProjectModels
{
    public class Locations
    {
        [Key]
        public int LocationId { get; set; }
        public string ZipCode { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string StateAbbreviation { get; set; }
    }
    public class Cities
    {
        public string CityName { get; set; }
    }
}