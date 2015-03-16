namespace StaffTracker.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using StaffTracker.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<StaffTracker.StaffTrackerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "StaffTracker.StaffTrackerContext";
        }

        protected override void Seed(StaffTracker.StaffTrackerContext context)
        {

            context.Individuals.AddOrUpdate(i => new { i.FirstMidName, i.BirthDay },

                new Individual
                {
                    BirthDay = "11/19/1983",
                    LastName = "Ted",
                    FirstMidName = "Killer",
                    EnterDate = new DateTime(2013, 2, 2),
                    Description = "strings",
                    Picture = "yadayada"
                },
                new Individual
                {
                    BirthDay = "11/19/1990",
                    LastName = "Billy",
                    FirstMidName = "Smith",
                    EnterDate = new DateTime(2008, 3, 5),
                    Description = "Good Guy",
                    Picture = "Drapered"
                });

            context.Staffs.AddOrUpdate(i => new { i.FirstMidName, i.BirthDay},

                new Staff
                {
                    BirthDay = "12/12/1984",
                    LastName = "bill",
                    FirstMidName = "nutso",
                    IndividualID = 1,
                    HireDate = new DateTime(2014, 2, 2)
                },
                new Staff
                {
                    BirthDay = "12/12/1976",
                    LastName = "Laura",
                    FirstMidName = "Land",
                    IndividualID = 2,
                    HireDate = new DateTime(2012, 1, 4)
                }
                );   
            

                context.Administrators.AddOrUpdate(i => new { i.FirstMidName, i.BirthDay},
                 new Administrator {
                    BirthDay = "11/19/1975",
                    LastName = "Thomas",
                    FirstMidName = "Richard",
                    HireDate = new DateTime(2008, 3, 5),
                    
                });

                context.Behaviors.AddOrUpdate(i => new { i.Time, i.Date },
                    new Behavior
                    {
                        IndividualID = 1,
                        StaffID = 1,
                        Date = new DateTime(2014, 5, 10),
                        Time = "4:30 PM",
                        Type = "Punch",
                        Antecedant = "Lunch",
                        Duration = 1,
                        Intensity = 1,
                        Resolution = "stopped"
                    },
                     new Behavior
                     {
                         IndividualID = 2,
                         StaffID = 2,
                         Date = new DateTime(2014, 9, 10),
                         Time = "4:00 PM",
                         Type = "Hit",
                         Antecedant = "Dinner",
                         Duration = 10,
                         Intensity = 7,
                         Resolution = "Ender"
                     });
                      
                    
                    
                    
 
            
            
            
            
            
                
            
            
            
            
            
            
            
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
