using MOD.Userservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Userservice.Repositories
{
    public interface IMentorRepository
    {
        void AddMentor(Mentor item);
        void UpdateMentorPassword(Mentor item);
        void DeleteMentor(long Id);
        void BlockMentor(long id);
        void UnBlockMentor(long id);
        List<Mentor> GetAll();
        Mentor GetById(long Id);
    }
}
