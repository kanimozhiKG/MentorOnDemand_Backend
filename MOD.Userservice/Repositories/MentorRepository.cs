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
            _context.mentor.Add(item);
            _context.SaveChanges();
        }

        public void BlockMentor(long id)
        {
            var item = _context.mentor.Find(id);
            if (item.Active == true)
            {
                item.Active = !(item.Active);
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();


        }
        public void UnBlockMentor(long id)
        {
            var item = _context.mentor.Find(id);
            if (item.Active == false)
            {
                item.Active = !(item.Active);
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();


        }

        public void DeleteMentor(long Id)
        {
            var item = _context.mentor.Find(Id);
            _context.mentor.Remove(item);
            _context.SaveChanges();
        }

        public List<Mentor> GetAll()
        {
            return _context.mentor.ToList();
        }

        public Mentor GetById(long Id)
        {
            return _context.mentor.Find(Id);
        }


        public void UpdateMentorPassword(Mentor item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }

}
