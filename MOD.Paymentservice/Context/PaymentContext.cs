using Microsoft.EntityFrameworkCore;
using MOD.Paymentservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Paymentservice.Context
{
    public class PaymentContext:DbContext
    {

        public DbSet<User> user { get; set; }
        public DbSet<Mentor> mentor { get; set; }
        public DbSet<Training> training { get; set; }
        public DbSet<Technology> technology { get; set; }
        public DbSet<Payment> payment { get; set; }
        public object Mentors { get; set; }
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server =DESKTOP-64P1ILH\KANI;Database=MODDB;Trusted_Connection=True;");
        //}
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Payment>().HasData(new Payment
            {
                PaymentId = 1233456,
                UserId = 75433,
                MentorId = 976454,
                Amount=7675,
            MentorAmount=4444
            });
        }

    }
}
