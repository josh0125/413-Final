using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class EFEntertainerRepository : iEntertainerRepository
    { 
        private EntertainmentAgencyExampleContext context {get; set;}

        public EFEntertainerRepository (EntertainmentAgencyExampleContext temp)
        {
            context = temp;
        }

        public void DeleteEntertainer(Entertainer e)
        {
            context.Entertainers.Remove(e);
            context.SaveChanges();
        }
        
        public void EditEntertainer(Entertainer e)
        {
            context.Entertainers.Update(e);
            context.SaveChanges();
        }

        public void AddEntertainer(Entertainer e)
        {
            context.Add(e);
            context.SaveChanges();
        }

        

            
        public IQueryable<Entertainer> Entertainers => context.Entertainers;
    }
}
