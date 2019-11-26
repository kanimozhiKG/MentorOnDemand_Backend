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
            try {

                _context.user.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BlockUser(long id)
        {
            try {
                var item = _context.user.Find(id);
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
        public void UnBlockUser(long id)
        {
            try
            {
                var item = _context.user.Find(id);
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

        public void DeleteUser(long id)
        {
            try {
                var item = _context.user.Find(id);
                _context.user.Remove(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<User> GetAll()
        {
            try {
                return _context.user.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<Mentor> SearchMentor(string Skill)
        {
            try {
                return _context.mentor.Where(i => i.skills == Skill).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdatePassword(User item)
        {
            try
            {
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}