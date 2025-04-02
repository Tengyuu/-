using Microsoft.AspNetCore.Mvc;
using 練習.Models;

namespace 練習.Controllers
{
    public class RazorScoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly List<Student> students;
        public RazorScoresController()
        {
            students = new List<Student>()
            {
                new Student() {Id = 1,Name = "Joe",Chinese=88,English=95,Math=71},
                new Student() {Id = 12,Name = "Mary",Chinese=92,English=82,Math=60},
                new Student() {Id = 23,Name = "Cathy",Chinese=98,English=91,Math=94},
            };

        }
        public IActionResult Scores()
        {
            return View(students);
        }
      
    }
}
