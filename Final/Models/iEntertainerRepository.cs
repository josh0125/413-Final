using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public interface iEntertainerRepository
    {
        void DeleteEntertainer(Entertainer e);

        void EditEntertainer(Entertainer e);

        void AddEntertainer(Entertainer e);

        IQueryable<Entertainer> Entertainers { get; }
    }
}
