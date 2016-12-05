using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IIW.Models.ProjectModels
{
    public class Attractions
    {
        [Key]
        public int AttractionId { get; set; }
        public string AttractionName { get; set; }
        public string AttractionAddress { get; set; }
        public string AttractionDescription { get; set; }
        public string AttractionImgSource { get; set; }
    }
}