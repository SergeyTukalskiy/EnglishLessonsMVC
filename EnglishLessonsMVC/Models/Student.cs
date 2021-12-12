using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnglishLessonsMVC.Models
{
    public class Student
    {
        public int ID { get; set; }
        [StringLength(50)]
        [Column("FirstName")]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        public int TeacherID { get; set; }
        public int GroupID { get; set; }

        public Teacher Teacher { get; set; }
        public Group Group { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
    }
}
