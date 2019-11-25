using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Technologyservice.Context;
using MOD.Technologyservice.Models;

namespace MOD.Technologyservice.Repositories
{
    public class TechnologyRepository : ITechnologyRepository
    {
        private readonly TechnologyContext _context;
        public TechnologyRepository(TechnologyContext context)
        {
            _context = context;
        }

        public List<Technology> GetAll()
        {
            return _context.technology.ToList();
        }

        public void Add(Technology item)
        {
            _context.technology.Add(item);
            _context.SaveChanges();

        }

        public Technology GetById(long Id)
        {
            return _context.technology.Find(Id);
        }

        public void Update(Technology item)
        {
            _context.Entry(item).State =
                   Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

        }
    }
}
