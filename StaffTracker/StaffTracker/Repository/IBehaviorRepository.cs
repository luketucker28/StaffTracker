using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StaffTracker.Models;
using System.Linq.Expressions;

namespace StaffTracker.Repository
{
        public interface IBehaviorRepository
        {
            int GetCount(); 
            void Add(Behavior E); 
            void Delete(Behavior E); 
            void Clear(); 
            IEnumerable<Behavior> PastBehaviors(); 
            IEnumerable<Behavior> All(); //
            Behavior GetById(int IndividualID); //
            Behavior GetByDate(DateTime a); //
       
        }
    }
