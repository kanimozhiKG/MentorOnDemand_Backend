using Microsoft.EntityFrameworkCore;
using MOD.Userservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Userservice.Context
{
    public class UserContext:DbContext
    {
        public DbSet<User> user { get; set; }
        public DbSet<Mentor> mentor { get; set; }
        public DbSet<Training> training { get; set; }
        public DbSet<Technology> technology { get; set; }
        public DbSet<Payment> payment { get; set; }
        public object Mentors { get; internal set; }

        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server =DESKTOP-64P1ILH\KANI;Database=MODDB;Trusted_Connection=True;");
        //}
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                Name = "aaaaaa",
                EmailID = "iiiiiiiii",
                Mobilenumber = 4000034655,
                Password = "ifgdfd",
                Active=true
            }, new User
            {
                UserId = 2,
                Name = "afdhgvha",
                EmailID = "iiiiiiiii",
                Mobilenumber = 7889334655,
                Password = "lkjhgfdsa",
                Active = true
            });
        }

    }
}
