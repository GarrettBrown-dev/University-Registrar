using Microsoft.AspNetCore.Mvc;
using UniReg.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UniReg.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly UniRegContext _db;

        public DepartmentsController(UniRegContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Department> model = _db.Departments.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            _db.Departments.Add(department);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AddCourse(int id)
        {
            var thisDepartment = _db.Departments.FirstOrDefault(departments => departments.DepartmentId == id);
            ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "CourseName");
            return View(thisDepartment);
        }

        [HttpPost]
        public ActionResult AddCourse(Department department, int CourseId)
        {
            if (CourseId != 0)
            {
                _db.DepartmentCourse.Add(new DepartmentCourse() { CourseId = CourseId, DepartmentId = department.DepartmentId });
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisDepartment = _db.Departments
            .Include(department => department.Courses)
            .ThenInclude(join => join.Course)
            .FirstOrDefault(department => department.DepartmentId == id);
            return View(thisDepartment);
        }

        public ActionResult Edit(int id)
        {
            var thisDepartment = _db.Departments.FirstOrDefault(department => department.DepartmentId == id);
            return View(thisDepartment);
        }

        [HttpPost]
        public ActionResult Edit(Department Department)
        {
            _db.Entry(Department).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var thisDepartment = _db.Departments.FirstOrDefault(department => department.DepartmentId == id);
            return View(thisDepartment);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisDepartment = _db.Departments.FirstOrDefault(department => department.DepartmentId == id);
            _db.Departments.Remove(thisDepartment);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}