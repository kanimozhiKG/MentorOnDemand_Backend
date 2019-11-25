using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.TrainingService.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public long UserId { get; set; }
        public string Name { get; set; }
        public string EmailID { get; set; }
        public long Mobilenumber { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<Payment> Payments { get; set; }
    }
}
