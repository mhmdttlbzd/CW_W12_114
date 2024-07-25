using CW_W12_114.Models;
using CW_W12_114.Utiliti;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CW_W12_114.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var res = new MyQueue<Student>();
            ViewBag.data = res.SetDefaultStudents();
            
            return View();
        }
        public IActionResult FilterStudent(int id)
        {
            var res = new MyQueue<Student>();
            ViewBag.data = res.SetDefaultStudents().FilterStudent(id);
            ViewData["success"] = "موفق";
            return View("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
