using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.TrainingService.Context;
using MOD.TrainingService.Models;

namespace MOD.TrainingService.Repositories
{
    public class TrainingRepository : ITrainingRepository
    {
        private readonly TrainingContext _context;
        public TrainingRepository(TrainingContext context)
        {
            _context = context;
        }

        public void Add(Training item)
        {
            try {
                _context.Training.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Training> GetAll()
        {
            try
            {
                return _context.Training.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Training> GetTrainingByUserId(long id)
        {
            try
            {
                return _context.Training.Where(i => i.UserId == id).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Training> GetTrainingByMentorId(long id)
        {
            try
            {
                return _context.Training.Where(i => i.MentorId == id).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Training item)
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
