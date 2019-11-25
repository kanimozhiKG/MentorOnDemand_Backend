using Microsoft.EntityFrameworkCore;
//using MOD.Technologyservice.models;
using MOD.Technologyservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Technologyservice.Context
{
    public class TechnologyContext:DbContext
    {
        public DbSet<User> user { get; set; }
        public DbSet<Mentor> mentor { get; set; }
        public DbSet<Training> training { get; set; }
        public DbSet<Technology> technology { get; set; }
        public DbSet<Payment> payment { get; set; }
        public object Mentors { get; set; }

        public TechnologyContext(DbContextOptions<TechnologyContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server =DESKTOP-64P1ILH\KANI;Database=MODDB;Trusted_Connection=True;");
        //}
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Technology>().HasData(new Technology
            {
                SkillId = 1233456,
                SkillName = "c++",
                TableOfContent = "iiiiiiiii",
                Fee=40000,
                Duration=6
            }, new Technology
            {
                SkillId = 123987675,
                SkillName = "Java",
                TableOfContent = "iiiidffdi",
                Fee = 40000,
                Duration = 4
            });
        }

        }
}
