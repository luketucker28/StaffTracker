using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using StaffTracker.Models;

namespace StaffTracker
{
    public class StaffTrackerContext : DbContext
    {
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Behavior> Behaviors { get; set; }
    }
}