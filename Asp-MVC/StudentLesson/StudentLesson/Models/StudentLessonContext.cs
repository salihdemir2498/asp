using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLesson.Models
{
    public class StudentLessonContext : DbContext
    {
        public StudentLessonContext()
        {
        }

        public StudentLessonContext(DbContextOptions<StudentLessonContext> options) : base(options)
        {

        }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Section> Sections { get; set; } 
        public DbSet<Student> Students { get; set; }
        public DbSet<SectionLesson> SectionLessons { get; set; }
        public DbSet<StudentLesson> StudentLessons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) //optionsBuilder configüre edilmemiş ise yani veri tabanı ayarları yapılmamış ise
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-4JE8ADO\\SQLEXPRESS;Database=StudentLessonSection;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentLesson>()
                .HasKey(sc => new { sc.StudentId, sc.LessonId });
        }
    }
}
