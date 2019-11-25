
using MOD.Technologyservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Technologyservice.Repositories
{
    public interface ITechnologyRepository
    {
        void Add(Technology item);
        void Update(Technology item);
        public List<Technology> GetAll();
        Technology GetById(long Id);
    }
}
