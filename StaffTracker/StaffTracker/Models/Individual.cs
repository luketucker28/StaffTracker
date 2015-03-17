using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StaffTracker.Models
{
    public class Individual
    {
        public int IndividualID { get; set; }
        [Required]
        public string BirthDay { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]

        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        [Required]
        public DateTime EnterDate { get; set; }
        [Required]
        [StringLength(150)]
        public string Description { get; set; }
        public string Picture { get; set; }
        public DateTime? DischargeDate { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
        public virtual ICollection<Behavior> Behaviors { get; set; }

        public Individual()
        {

        }
        public Individual(string birthday , string lastname, string firstmidname, DateTime enterdate, string description, string picture, DateTime? discharge)  {
            this.BirthDay = birthday;
            this.LastName = lastname;
            this.FirstMidName = firstmidname;
            this.EnterDate = enterdate;
            this.Description = description;
            this.Picture = picture;
            this.DischargeDate = discharge;
        }
    }
}