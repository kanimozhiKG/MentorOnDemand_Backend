using MOD.TrainingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Repositories
{
    public interface ITrainingRepository
    {
        void Add(Training item);
        void Update(Training item);
        public List<Training> GetAll();
        List<Training> GetTrainingByUserId(long id);
        List<Training> GetTrainingByMentorId(long id);

    }
}
