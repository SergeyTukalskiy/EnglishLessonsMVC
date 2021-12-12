using EnglishLessonsMVC.Models;
using System;
using System.Linq;

namespace EnglishLessonsMVC.Data
{
    public static class DbInitializr
    {
        public static void Initialize(CoursesContext context)
        {
            context.Database.EnsureCreated();

            if(context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student{ FirstName = "Сергей", LastName = "Тукальский", TeacherID = 1, GroupID = 1 },
                new Student{ FirstName = "Джеф", LastName = "Безос", TeacherID = 1, GroupID = 1 },
                new Student{ FirstName = "Илон", LastName = "Маск", TeacherID = 1, GroupID = 2 },
                new Student{ FirstName = "Павел", LastName = "Дуров", TeacherID = 1, GroupID = 2 },
                new Student{ FirstName = "Марк", LastName = "Цукерберг", TeacherID = 2, GroupID = 3 },
                new Student{ FirstName = "Герман", LastName = "Греф", TeacherID = 2, GroupID = 3 },
                new Student{ FirstName = "Артем", LastName = "Дзюба", TeacherID = 2, GroupID = 4 },
                new Student{ FirstName = "Владимир", LastName = "Путин", TeacherID = 2, GroupID = 4 }
            };

            foreach (Student student in students)
            {
                context.Students.Add(student);
            }
            context.SaveChanges();

            var groups = new Group[]
            {
                new Group{ ID = 1, Name = "A01", TeacherID = 1},
                new Group{ ID = 2, Name = "A02", TeacherID = 1},
                new Group{ ID = 3, Name = "B01", TeacherID = 2},
                new Group{ ID = 4, Name = "B02", TeacherID = 2}
            };
            foreach (Group group in groups)
            {
                context.Groups.Add(group);
            }
            context.SaveChanges();

            var teachers = new Teacher[]
            {
                new Teacher{ FirstName = "Альфия", LastName = "Баранова"},
                new Teacher{ FirstName = "Гюзель", LastName = "Закирова"},
            };
            foreach (Teacher item in teachers)
            {
                context.Teachers.Add(item);
            }
            context.SaveChanges();

            var classes = new Class[]
            {
                new Class{ GroupID = 1, Date = DateTime.Parse("12/14/2018 10:00:00")},
                new Class{ GroupID = 1, Date = DateTime.Parse("12/16/2018 10:00:00")},
                new Class{ GroupID = 2, Date = DateTime.Parse("12/14/2018 12:00:00")},
                new Class{ GroupID = 2, Date = DateTime.Parse("12/16/2018 12:00:00")},
                new Class{ GroupID = 3, Date = DateTime.Parse("12/14/2018 14:00:00")},
                new Class{ GroupID = 3, Date = DateTime.Parse("12/16/2018 14:00:00")},
                new Class{ GroupID = 4, Date = DateTime.Parse("12/14/2018 16:00:00")},
                new Class{ GroupID = 4, Date = DateTime.Parse("12/16/2018 16:00:00")},
            };
            foreach (Class item in classes)
            {
                context.Classes.Add(item);
            }
            context.SaveChanges();

            var assignments = new Assignment[]
            {
                new Assignment{ Name = "Входной экзамен", StudentID = 1, Grade = Grade.A },
                new Assignment{ Name = "Входной экзамен", StudentID = 2, Grade = Grade.B },
                new Assignment{ Name = "Входной экзамен", StudentID = 3, Grade = Grade.C },
                new Assignment{ Name = "Входной экзамен", StudentID = 4, Grade = Grade.D },
                new Assignment{ Name = "Входной экзамен", StudentID = 5, Grade = Grade.D },
                new Assignment{ Name = "Входной экзамен", StudentID = 6, Grade = Grade.B },
                new Assignment{ Name = "Входной экзамен", StudentID = 7, Grade = Grade.C },
                new Assignment{ Name = "Входной экзамен", StudentID = 8, Grade = Grade.A },
            };

            foreach (Assignment assignment in assignments)
            {
                context.Assignments.Add(assignment);
            }
            context.SaveChanges();
        }
    }
}
