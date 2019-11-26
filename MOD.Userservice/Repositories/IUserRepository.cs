using MOD.Userservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Userservice.Repositories
{
    public interface IUserRepository
    {
        void AddUser(User item);
        public List<User> GetAll();
        void DeleteUser(long id);
        void BlockUser(long id);
        void UnBlockUser(long id);
        void UpdatePassword(User item);
        List<Mentor> SearchMentor(string Skill);


    }
}
