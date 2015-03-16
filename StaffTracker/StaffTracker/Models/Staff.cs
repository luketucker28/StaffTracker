using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StaffTracker.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
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
        
        public int IndividualID { get; set; }
      
        [Required]
        public DateTime HireDate { get; set; }
        public DateTime? EmploymentDischarge { get; set; }
        public virtual ICollection<Behavior> Behaviors { get; set; }
        public virtual Individual Individual { get; set; }

    }

}