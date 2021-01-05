using Microsoft.EntityFrameworkCore;

namespace UniReg.Models
{
    public class UniRegContext : DbContext
    {
        public virtual DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseStudent> CourseStudent { get; set; }

        public UniRegContext(DbContextOptions options) : base(options) { }
    }
}