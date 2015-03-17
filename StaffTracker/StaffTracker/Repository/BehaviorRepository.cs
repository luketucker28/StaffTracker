using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StaffTracker.Models;
using System.Data.Entity;


namespace StaffTracker.Repository
{

    public class BehaviorRepository 
    {
        private StaffTrackerContext _dbContext;

        public BehaviorRepository()
        {
            _dbContext = new StaffTrackerContext();
            _dbContext.Behaviors.Load();
        }
        public StaffTrackerContext Context()
        {
            return _dbContext;
        }

        public DbSet<Behavior> GetDbSet()
        {
            return _dbContext.Behaviors;
        }

        public int GetCount()
        {
            return _dbContext.Behaviors.Count<Behavior>();

        }

        public void Add(Behavior E)
        {  
            _dbContext.Behaviors.Add(E);
            _dbContext.SaveChanges();
        }

        public void Clear()
        {
            var b = this.All();
            _dbContext.Behaviors.RemoveRange(b);
        }

        public IEnumerable<Behavior> All()
        {
            var qu = from Behavior in _dbContext.Behaviors select Behavior;
            return qu.ToList<Behavior>();
        }

        public Behavior GetById(int id)
        {
            var query = from Behavior in _dbContext.Behaviors
                        where Behavior.BehaviorID == id
                        select Behavior;
            return query.First<Behavior>();

        }

        //public Behavior GetByDate(DateTime D)
        //{
        //    var query = from Behavior in _dbContext.Behaviors
        //                where Behavior.Date == D
        //                select Behavior;
        //    return query.ToList<Behavior>();
        //}

        public List<Behavior> GetByDate(DateTime d)
        {
            var a = from Behavior in _dbContext.Behaviors
                    where Behavior.Date == d
                    select Behavior;
            return a.ToList<Behavior>();

        }
        public IEnumerable<Behavior> OrderByDate()
        {
            var query = (from Behavior in _dbContext.Behaviors
                         orderby Behavior.Date
                         select Behavior).ToList();
            _dbContext.SaveChanges();
            return query;
        }
        public IEnumerable<Behavior> OrderById()
        {
            var query = (from Behavior in _dbContext.Behaviors
                         orderby Behavior.BehaviorID
                         select Behavior).ToList();
            _dbContext.SaveChanges();
            return query;
        }
        public Behavior FirstEntry()
        {

            var query = from Behavior in _dbContext.Behaviors select Behavior;
            return query.ToList<Behavior>().ElementAt<Behavior>(0);

        }
        public Behavior FindEntry(int i)
        {

            var query = from Behavior in _dbContext.Behaviors select Behavior;
            return query.ToList<Behavior>().ElementAt<Behavior>(i);

        }
        public void Delete(Behavior E)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Behavior> PastBehaviors()
        {
            throw new NotImplementedException();
        }

     
        public void Dispose()
        {

            _dbContext.Dispose();
        }
    }
}
