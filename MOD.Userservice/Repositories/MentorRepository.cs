using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.Userservice.Context;
using MOD.Userservice.Models;

namespace MOD.Userservice.Repositories
{
    public class MentorRepository : IMentorRepository
    {
        private readonly UserContext _context;
        public MentorRepository(UserContext context)
        {
            _context = context;
        }
        public void AddMentor(Mentor item)
        {
            try {
                _context.mentor.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BlockMentor(long id)
        {
            try
            {
                var item = _context.mentor.Find(id);
                if (item.Active == true)
                {
                    item.Active = !(item.Active);
                }
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }


        }
        public void UnBlockMentor(long id)
        {
            try
            {
                var item = _context.mentor.Find(id);
                if (item.Active == false)
                {
                    item.Active = !(item.Active);
                }
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }


        }

        public void DeleteMentor(long Id)
        {
            try {
                var item = _context.mentor.Find(Id);
                _context.mentor.Remove(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Mentor> GetAll()
        {
            try {
                return _context.mentor.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Mentor GetById(long Id)
        {
            try {
                return _context.mentor.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void UpdateMentorPassword(Mentor item)
        {
            try {
                _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
