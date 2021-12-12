using System;
using System.ComponentModel.DataAnnotations;

namespace EnglishLessonsMVC.Models
{
    public class Class
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public int GroupID { get; set; }

        public Group Group { get; set; }
    }
}
