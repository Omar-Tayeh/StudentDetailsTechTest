using Microsoft.EntityFrameworkCore;
using StudentDetailsTechTest.Models;
using System.Reflection.Emit;

namespace StudentDetailsTechTest.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Grades> Grades { get; set; }
    }
}
