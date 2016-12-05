using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IIW.Models.ProjectModels
{
    public class Events
    {
        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventAddress { get; set; }
        public string EventURL { get; set; }
        public string EventImgSource { get; set; }
    }
}