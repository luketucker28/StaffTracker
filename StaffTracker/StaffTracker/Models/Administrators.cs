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

        public Administrator()
        {

        }
        public Administrator(string birthday, string lastname, string firstname, DateTime hired, DateTime? discharge)
        {
            this.BirthDay = birthday;
            this.LastName = lastname;
            this.FirstMidName = firstname;
            this.HireDate = hired;
            this.DischargeDate = discharge;
        }
        
    } 
}