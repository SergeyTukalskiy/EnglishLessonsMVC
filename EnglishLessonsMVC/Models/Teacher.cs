using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnglishLessonsMVC.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        [StringLength(50)]
        [Column("FirstName")]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
