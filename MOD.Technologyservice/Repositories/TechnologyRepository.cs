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
            try
            {
                return _context.technology.ToList();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Add(Technology item)
        {
            try
            {
                _context.technology.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }


        }

        public Technology GetById(long Id)
        {
            try
            {
                return _context.technology.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Update(Technology item)
        {
            try
            {
                _context.Entry(item).State =
                       Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
