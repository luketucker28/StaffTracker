using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StaffTracker.Models
{
    public class Administrator
    {
        public int AdministratorID { get; set; }
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
        public DateTime HireDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public virtual ICollection<Individual> Individuals { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
        //    public virtual ICollection<Goals> Goal { get; set; }
        public virtual ICollection<Behavior> Behaviors { get; set; }

    } 
}