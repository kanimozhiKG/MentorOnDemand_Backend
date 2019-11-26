using Microsoft.AspNetCore.Mvc;
using MOD.Userservice.Models;
using MOD.Userservice.Repositories;
using System.Collections.Generic;

namespace MOD.Userservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        [Route("GetAll")]
        public List<User> Get()
        {
            return _repository.GetAll();
        }






        //[HttpGet("{id}", Name = "Get")]
        [Route("GetById/{id}")]
        //public User Get(int id)
        //{
        //    return _repository.GetById(id);
        //}


        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] User item)
        {
            _repository.AddUser(item);
            return Ok("Record Added");
        }


        [HttpPut("{id}")]
        [Route("Update")]

        public void Put(User item)
        {
            _repository.UpdatePassword(item);
        }


        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(long id)
        {
            _repository.DeleteUser(id);
        }
        [HttpPut("{id}")]
        [Route("BlockUser/{id}")]

        public void Block(long id)
        {
            _repository.BlockUser(id);

        }
        [HttpPut("{id}")]
        [Route("UnBlockUser/{id}")]

        public void UnBlock(long id)
        {
            _repository.UnBlockUser(id);

        }
        [Route("GetMentorBySkill/{id}")]
        public List<Mentor> Get(string id)
        {
            return _repository.SearchMentor(id);
        }



    }
}