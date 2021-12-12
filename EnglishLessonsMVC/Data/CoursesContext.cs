using EnglishLessonsMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EnglishLessonsMVC.Data
{
    public class CoursesContext : DbContext
    {
        public CoursesContext(DbContextOptions<CoursesContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Teacher>().ToTable("Teacher");
            modelBuilder.Entity<Class>().ToTable("Class");
            modelBuilder.Entity<Assignment>().ToTable("Assignment");
            modelBuilder.Entity<Group>().ToTable("Group");

        }
    }
}
