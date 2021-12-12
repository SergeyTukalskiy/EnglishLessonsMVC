using System.ComponentModel.DataAnnotations;

namespace EnglishLessonsMVC.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Assignment
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public Grade Grade { get; set; }
        public int StudentID { get; set; }

        public Student Student { get; set; }
    }
}
