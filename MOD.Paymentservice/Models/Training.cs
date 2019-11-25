﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace MOD.Paymentservice.Models
{
    [Table("Training")]
    public class Training { 
        [Key]
        public long TrainingId { get; set; }
        [ForeignKey("User")]
        public long UserId { get; set; }
        [ForeignKey("Mentor")]
        public long MentorId { get; set; }
        [ForeignKey("Technology")]
        public long SkillId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string timeslot { get; set; }
        public string status { get; set; }
        public string Progress { get; set; }
        public int rating { get; set; }
        public IEnumerable<Payment> Payments { get; set; }
        public User User { get; set; }
        public Mentor Mentor { get; set; }
        public Technology Technology { get; set; }
    }
}

