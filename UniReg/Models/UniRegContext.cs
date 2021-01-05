using Microsoft.EntityFrameworkCore;

namespace UniReg.Models
{
    public class UniRegContext : DbContext
    {
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<CourseStudent> CourseStudent { get; set; }
        public DbSet<DepartmentCourse> DepartmentCourse { get; set; }
        // public DbSet<DepartmentCourseStudent> DepartmentCourseStudent { get; set; }

        public UniRegContext(DbContextOptions options) : base(options) { }
    }
}