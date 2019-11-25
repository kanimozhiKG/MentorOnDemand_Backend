using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Paymentservice.Models
{
    [Table("Mentor")]
    public class Mentor
    {
        [Key]
        public long MentorId { get; set; }
        public string MentorName { get; set; }
        public string MEmailID { get; set; }
        public long mobilenumber { get; set; }
        public string experiance { get; set; }

        public string skills { get; set; } 

        public string timeslot { get; set; }

        public bool availability { get; set; }

        public string Password { get; set; }
        public bool Active { get; set; }

        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<Payment> payments { get; set; }
    }
}
