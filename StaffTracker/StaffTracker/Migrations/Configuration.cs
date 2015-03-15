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

            context.Individuals.AddOrUpdate(x => x.LastName,

              new Individual
              {
                  BirthDay = "todo",
                  LastName = "me",
                  FirstMidName = "Jim",
                  EnterDate = new DateTime(2014, 3, 4),
                  Description = "heavy set",
                  Picture = "yada"
              },
              new Individual
              {
                  BirthDay = "to",
                  LastName = "leg",
                  FirstMidName = "Jim",
                  EnterDate = new DateTime(2014, 3, 4),
                  Description = "heavy set",
                  Picture = "yada"
              }

            );
           // context.Staffs.AddOrUpdate(x => x.LastName,
           
           //   new Staff {
           //       IndividualID = 1,
           //       FirstMidName = "tim",
           //       LastName = "me",
           //       HireDate = new DateTime(2014, 2, 4)
           //   }
              
           // );
            
           // context.Administrators.AddOrUpdate(x => x.LastName,

           //  new Administrator
           //  {
           //      BirthDay = "todo",
           //      LastName = "me",
           //      FirstMidName = "Jim",
           //      HireDate = new DateTime(2014, 3, 4)
           //  }

           //);

           // context.Behaviors.AddOrUpdate(x => x.Type,

           //  new Behavior
           //  {
           //      IndividualID = 1,
           //      StaffID = 1,
           //      Date= new DateTime(2015, 2, 2),
           //      Time = "4:30",
           //      Type = "hit",
           //      Antecedant = "punch",
           //      Duration = 10,
           //      Intensity = 5,
           //      Resolution = "smacked"
           //  }

           //);
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
           
            //
           
        }
      
    }
}
