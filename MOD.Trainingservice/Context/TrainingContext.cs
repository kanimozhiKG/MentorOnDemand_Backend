using Microsoft.EntityFrameworkCore;
using MOD.TrainingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Context
{
    public class TrainingContext:DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Technology> Technology { get; set; }
        public DbSet<Payment> Payment { get; set; }
        

        public TrainingContext(DbContextOptions<TrainingContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server =DESKTOP-64P1ILH\KANI;Database=MODDB;Trusted_Connection=True;");
        //}
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Training>().HasData(new Training
            {
                TrainingId = 1233456,
                UserId = 75433,
                MentorId = 976454,
                SkillId = 40000,
                StartDate = DateTime.Parse("09-11-2019"),
                EndDate = DateTime.Parse("09-02-2020"),
                Timeslot = "Eve",
                Status="OnProgress",
                Progress="half",
                Rating=67
            });
        }

    }
}
