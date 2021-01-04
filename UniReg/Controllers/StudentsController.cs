using Microsoft.AspNetCore.Mvc;
using UniReg.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UniReg.Controllers
{
    public class StudentsController : Controller
    {
        private readonly UniRegContext _db;

        public StudentsController(UniRegContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Students.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Students student, int CourseId)
        {
            _db.Students.Add(student);
            if (CourseId != 0)
            {
                _db.CourseStudent.Add(new CourseStudent() { CourseId = CourseId, StudentId = student.StudentId });
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisStudent = _db.Students
            .Include(student => student.Courses)
            .ThenInclude(join => join.Courses)
            .FirstOrDefault(student => student.StudentId == id);
            return View(thisStudent);
        }

//         public ActionResult Edit(int id)
//         {
//             var thisStudent = _db.Students.FirstOrDefault(Students => students.StudentId == id);
//             ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
//             return View(thisStudent);
//         }

//         [HttpPost]
//         public ActionResult Edit(Student student)
//         {
//             _db.Entry(student).State = EntityState.Modified;
//             _db.SaveChanges();
//             return RedirectToAction("Index");
//         }

//         public ActionResult Delete(int id)
//         {
//             var thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
//             return View(thisStudent);
//         }

//         [HttpPost, ActionName("Delete")]
//         public ActionResult DeleteConfirmed(int id)
//         {
//             var thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
//             _db.Students.Remove(thisStudent);
//             _db.SaveChanges();
//             return RedirectToAction("Index");
//         }

//     }


// }