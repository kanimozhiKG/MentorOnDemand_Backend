using MOD.Authenticateservice.Context;
using MOD.Authenticateservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Authenticateservice.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly LoginContext _context;
        public LoginRepository(LoginContext context)
        {
            _context = context;
        }

        public Mentor MentorLogin(string email, string pwd)
        {
            try
            {
                return _context.mentor.SingleOrDefault(data => data.MEmailID == email && data.Password == pwd);
            }
            catch (Exception)
            {
                throw;
            }
            //    if (obj != null)
        //        return true;
        //    else
        //        return false;
        }

        public User UserLogin(string email, string pwd)
        {
            try
            {
                return _context.user.SingleOrDefault(data => data.EmailID == email && data.Password == pwd);
            }
            catch (Exception)
            {
                throw;
            }
            //if (obj != null)
            //    return true;
            //else
            //    return false;


        }
    }
}
