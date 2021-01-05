using System.Collections.Generic;

namespace UniReg.Models
{
    public class Department
    {
        public Department()
        {
            this.Courses = new HashSet<DepartmentCourse>();
        }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public virtual ICollection<DepartmentCourse> Courses { get; set; }
    }
}