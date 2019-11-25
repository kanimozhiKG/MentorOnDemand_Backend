using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.Userservice.Models;
using MOD.Userservice.Repositories;

namespace MOD.Userservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorController : ControllerBase
    {
        private readonly IMentorRepository _repository;
        public MentorController(IMentorRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Mentor
        [HttpGet]
        [Route("GetAllMentor")]
        public List<Mentor> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Mentor/5
        //[HttpGet("{id}", Name = "Get")]
        [Route("GetMentorById/{id}")]
        public Mentor Get(long id)
        {
            return _repository.GetById(id);
        }

        // POST: api/Mentor
        [HttpPost]
        [Route("AddUser")]
        public IActionResult Post([FromBody] Mentor item)
        {
            _repository.AddMentor(item);
            return Ok("Record Added");
        }

        // PUT: api/Mentor/5
        [HttpPut("{id}")]
        [Route("UpdateMentor")]
        public void Put(Mentor item)
        {
            _repository.UpdateMentorPassword(item);
        }
        [HttpPut("{id}")]
        [Route("UnBlockMentor/{id}")]

        public void UnBlock(long id)
        {
            _repository.UnBlockMentor(id);

        }
        [HttpPut("{id}")]
        [Route("BlockMentor/{id}")]

        public void Block(long id)
        {
            _repository.BlockMentor(id);

        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(long id)
        {
            _repository.DeleteMentor(id);
        }
    }

}

