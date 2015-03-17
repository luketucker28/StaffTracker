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

        public Behavior()
        {

        }
            public Behavior( int indI, int staffI, DateTime date, string time, string types, string before, int durat, int intens, string res)
        {
            this.IndividualID = indI;
            this.StaffID = staffI;
            this.Date = date;
            this.Time = time;
            this.Type = types;
            this.Antecedant = before;
            this.Duration = durat;
            this.Intensity = intens;
            this.Resolution = res;

        }
    }
}