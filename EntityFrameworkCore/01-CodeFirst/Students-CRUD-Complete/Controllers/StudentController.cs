using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using students_crud.Models;

namespace students_crud.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext myDB;

        public StudentController(StudentDbContext myDb)
        {
            this.myDB = myDb;
        }

        public IActionResult Index()
        {
            var StudentData = myDB.Students.ToList();
            return View(StudentData);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student stu)
        {
            if (ModelState.IsValid)
            {
                myDB.Students.Add(stu);
                myDB.SaveChanges();
                return RedirectToAction("Success");
            }
            return View(stu);
        }
        public IActionResult Success()
        {
             return RedirectToAction("Index", "Student");
        }

        public IActionResult Edit(int? id)
        {
            var stData = myDB.Students.Find(id);
            if (stData == null)
            {
                return NotFound();
            }
            return View(stData);
        }

        [HttpPost]
        public IActionResult Edit(int? id,Student obj)
        {
            if(id != obj.studentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                myDB.Students.Update(obj);
                myDB.SaveChanges();
                return RedirectToAction("Index", "Student");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if(id== null || myDB.Students== null)
            {
                return NotFound();
            }
            var stdData = myDB.Students.FirstOrDefault(x => x.studentId == id);
            if (stdData == null)
            {
                return NotFound();
            }

            return View(stdData);
         }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteRecord(int? id)
        {
            var stData = myDB.Students.Find(id);
            if (stData != null)
            {

                myDB.Students.Remove(stData);
            }
            myDB.SaveChanges();
            return RedirectToAction("Index", "Student");
        }












    }
}
