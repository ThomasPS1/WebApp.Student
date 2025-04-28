using Microsoft.EntityFrameworkCore;
using WebApp.Student.Models;

namespace WebApp.Student.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<Instructors> Instructors { get; set; }






    }
}
