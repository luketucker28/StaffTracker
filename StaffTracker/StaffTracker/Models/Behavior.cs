using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StaffTracker.Models
{
        public class Behavior
    {
        public int BehaviorID { get; set; }
        public int IndividualID { get; set; } 
        public int StaffID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Antecedant { get; set; }
        [Required]
        public int Duration  {get; set;}
        [Required]
        public int Intensity { get; set; }
        [Required]
        public string Resolution { get; set; }
        public virtual Individual Individual { get; set; }
        public virtual Staff Staff { get; set; }
    }
}