using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using MOD.Technologyservice.Repositories;

using MOD.Technologyservice.Controllers;
using Xunit;
using MOD.Technologyservice.Models;
using Microsoft.AspNetCore.Mvc;

namespace MOD.test
{
   public class TechnologyTest
    {
        private readonly Mock<ITechnologyRepository> _repo;
        private readonly TechnologyController _controller;
        public TechnologyTest()
        {
            _repo = new Mock<ITechnologyRepository>();

            _controller = new TechnologyController(_repo.Object);
        }
        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.GetAll()).Returns(GetTechnologies());
            var result = _controller.Get() as List<Technology>;
            Assert.Equal(3, result.Count);
        }
        [Fact]
        public void GetByID()
        {
            _repo.Setup(m => m.GetById(1)).Returns(GetTechnologies()[0]);
            var result = _controller.Get(1) as Technology;
            Assert.Equal(1, result.SkillId);
            Assert.NotNull(result);
        }
        private List<Technology> GetTechnologies()
        {
            return new List<Technology>()
            {
                new Technology(){ SkillId =1,SkillName="c++"},
                new Technology(){ SkillId =2,SkillName="python"},
                new Technology(){ SkillId =3,SkillName="java"}
            };
        }
        [Fact]
        public void Post()
        {
            var item = GetTechnologies()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void Put()
        {
            var item= GetTechnologies()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);
}
    }
}
