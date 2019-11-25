using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.TrainingService.Models;
using MOD.TrainingService.Repositories;

namespace MOD.TrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingRepository _repository;


        public TrainingController(ITrainingRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("GetAll")]
        public List<Training> Get()
        {
            return _repository.GetAll();
        }


        

        // POST: api/Training
        [HttpPost]
        [Route("Add")]

        public IActionResult Post([FromBody] Training item)
        {
            _repository.Add(item);
            return Ok("Record Added..");

        }

        // PUT: api/Training/5
        [HttpPut("{id}")]
        [Route("Update")]
        public void Put( [FromBody] Training item)
        {
            _repository.Update(item);
        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        [HttpGet("{id}", Name = "Get")]
        [Route("GetTrainingByUser/{id}")]
        public List<Training> Get(int id)
        {
            return _repository.GetTrainingByUserId(id);
        }
        [HttpGet("{id}", Name = "Get")]
        [Route("GetTrainingByMentor/{id}")]

        public List<Training> GetbyMentor(int id)
        {
            return _repository.GetTrainingByMentorId(id);

        }

    }
}
