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
            _context.Training.Add(item);
            _context.SaveChanges();
        }

        public List<Training> GetAll()
        {
            return _context.Training.ToList();
        }

        public List<Training> GetTrainingByUserId(long id)
        {
            return _context.Training.Where(i => i.UserId == id).ToList();
        }
        public List<Training> GetTrainingByMentorId(long id)
        {
            return _context.Training.Where(i => i.MentorId == id).ToList();
        }

        public void Update(Training item)
        {
            _context.Entry(item).State =
                   Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

        }
    }
}
