using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnglishLessonsMVC.Models
{
    public class Group
    {
        public int ID { get; set; }
        [StringLength(4)]
        public string Name { get; set; }
        public int TeacherID { get; set; }

        public Teacher Teacher { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Class> Classes { get; set; }
    }
}
