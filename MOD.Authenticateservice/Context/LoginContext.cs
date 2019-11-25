using Microsoft.EntityFrameworkCore;
using MOD.Authenticateservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Authenticateservice.Context
{
    public class LoginContext:DbContext
    {


        public DbSet<User> user { get; set; }
        public DbSet<Mentor> mentor { get; set; }
        public DbSet<Training> training { get; set; }
        public DbSet<Technology> technology { get; set; }
        public DbSet<Payment> payment { get; set; }
        //public object Mentors { get; set; }

        public LoginContext(DbContextOptions<LoginContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server =DESKTOP-64P1ILH\KANI;Database=MODDB;Trusted_Connection=True;");
        //}
        

    }
}
