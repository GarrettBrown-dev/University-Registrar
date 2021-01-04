// using Microsoft.AspNetCore.Mvc;
// using UniReg.Models;
// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.EntityFrameworkCore;

// namespace UniReg.Controllers
// {
//     public class CoursesController : Controller
//     {
//         private readonly UniRegContext _db;

//         public CoursesController(UniRegContext db)
//         {
//             _db = db;
//         }

//         public ActionResult Index()
//         {
//             List<Course> model = _db.Courses.ToList();
//             return View(model);
//         }

//         public ActionResult Create()
//         {
//             return View();
//         }

//         [HttpPost]
//         public ActionResult Create(Course course)
//         {
//             _db.Courses.Add(course);
//             _db.SaveChanges();
//             return RedirectToAction("Index");
//         }

//         public ActionResult Details(int id)
//         {
//             Course thisCourse = _db.Courses
//             .Include(course => course.Students)
//             .FirstOrDefault(course => course.CourseId == id);
//             return View(thisCourse);
//         }

//         public ActionResult Edit(int id)
//         {
//             var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
//             return View(thisCourse);
//         }

//         [HttpPost]
//         public ActionResult Edit(Course Course)
//         {
//             _db.Entry(Course).State = EntityState.Modified;
//             _db.SaveChanges();
//             return RedirectToAction("Index");
//         }

//         public ActionResult Delete(int id)
//         {
//             var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
//             return View(thisCourse);
//         }

//         [HttpPost, ActionName("Delete")]
//         public ActionResult DeleteConfirmed(int id)
//         {
//             var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
//             _db.Courses.Remove(thisCourse);
//             _db.SaveChanges();
//             return RedirectToAction("Index");
//         }
//     }
// }