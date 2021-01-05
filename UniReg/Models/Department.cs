using System.Collections.Generic;

namespace UniReg.Models
{
    public class Department
    {
        public Department()
        {
            this.Courses = new HashSet<DepartmentCourseStudent>();
        }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<DepartmentCourseStudent> Courses { get; set; }
    }
}