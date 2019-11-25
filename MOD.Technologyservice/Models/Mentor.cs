using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace MOD.Technologyservice.Models
{
    [Table("Mentor")]
    public class Mentor
    {
        [Key]
        public long MentorId { get; set; }
        public string MentorName { get; set; }
        public string MEmailID { get; set; }
        public long Mobilenumber { get; set; }
        public string Experiance { get; set; }

        public string Skills { get; set; }

        public string Timeslot { get; set; }

        public bool Availability { get; set; }

        public string Password { get; set; }
        public bool Active { get; set; }

        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<Payment> Payments { get; set; }
    }
}
