using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD.Userservice.Context;
using MOD.Userservice.Models;

namespace MOD.Userservice.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public void AddUser(User item)
        {

            _context.user.Add(item);
            _context.SaveChanges();
        }

        public void BlockUser(long id)
        {

            var item = _context.user.Find(id);
            item.Active = !(item.Active);
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteUser(long id)
        {
            var item = _context.user.Find(id);
            _context.user.Remove(item);
            _context.SaveChanges();
        }
        public List<User> GetAll()
        {
            return _context.user.ToList();
        }


        public List<Mentor> SearchMentor(string Skill)
        {
            return _context.mentor.Where(i => i.skills == Skill).ToList();
        }

        public void UpdatePassword(User item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();

        }
    }
}