using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MOD.Technologyservice.Models;
using Microsoft.AspNetCore.Mvc;
using MOD.Technologyservice.Repositories;
//using MOD.Technologyservice.Models;

namespace MOD.Technologyservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyController : ControllerBase
    {
        private readonly ITechnologyRepository _repository;
       

        public TechnologyController(ITechnologyRepository repository)
            {
            _repository = repository;
        }

        [HttpGet]
        [Route("GetAll")]
        public List<Technology> Get()
        {
            return _repository.GetAll();
        }
        [Route("GetTechById/{id}")]
        public Technology Get(long id)
        {
            return _repository.GetById(id);
        }



        // GET: api/Technology/5
        //[HttpGet("{id}", Name = "Get")]
       // public string Get(int id)
        //{
        //    return "value";
      //  }

        // POST: api/Technology
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Technology item)
        {
            _repository.Add(item);
            return Ok();

        }
        

        // PUT: api/Technology/5
        [HttpPut("{id}")]
        [Route("Update")]
        public IActionResult Put(Technology item)
        {
            _repository.Update(item);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
