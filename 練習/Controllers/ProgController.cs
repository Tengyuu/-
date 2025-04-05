using Microsoft.AspNetCore.Mvc;

namespace 練習.Controllers
{
    public class ProgController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
   
        public IActionResult Prog1(string rows,string cols,string text)
        {
            ViewBag.Rows = rows;
            ViewBag.Cols = cols;
            ViewBag.Text = text;
            return View();
        }
        public IActionResult Prog2(string input)
        {
           
            ViewBag.Input = input;      
            return View();
        }
        public IActionResult Prog3(string s)
        {
            ViewBag.S = s;
            ViewBag.S = s;
            return View();
        }
        public IActionResult Prog4()
        {
            
            return View();
        }
    }
}
