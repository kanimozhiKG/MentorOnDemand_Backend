using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.Paymentservice.Models;
using MOD.Paymentservice.Repositories;

namespace MOD.Paymentservice.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository _repository;


        public PaymentController(IPaymentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("GetAll")]
        public List<Payment> Get()
        {
            return _repository.GetAll();
        }


        // GET: api/Payment/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Payment
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Payment item)
        {
            _repository.Add(item);
            return Ok("Record Added..");

        }


        // PUT: api/Payment/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
