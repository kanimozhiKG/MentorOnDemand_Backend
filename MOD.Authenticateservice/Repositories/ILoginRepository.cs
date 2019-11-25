using MOD.Authenticateservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Authenticateservice.Repositories
{
   public interface ILoginRepository
    {
        User UserLogin(string email, string pwd);
        Mentor MentorLogin(string email, string pwd);
    }
}
