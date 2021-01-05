namespace UniReg.Models
{
    public class DepartmentCourse
    {
        public int DepartmentCourseId { get; set; }
        public int DepartmentId { get; set; }
        public int CourseId { get; set; }
        public string DepartmentName { get; set; }
        public string CourseName { get; set; }
        public Department Department { get; set; }
        public Course Course { get; set; }
    }

}