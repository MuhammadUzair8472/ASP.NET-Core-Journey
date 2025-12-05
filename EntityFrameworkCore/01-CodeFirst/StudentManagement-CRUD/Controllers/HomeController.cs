using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentManagment.Models;

namespace StudentManagment.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDbContext studentDb;

        public HomeController(StudentDbContext studentDb)
        {
            this.studentDb = studentDb;
        }
        public IActionResult Index()
        {
            var stdData = studentDb.Students.ToList();
            return View(stdData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
