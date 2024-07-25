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

        public IActionResult GetFullName(int count = 10)
        {
            var queue = new MyQueue<Student>();
            List<IStudent> res = queue.SetDefaultStudents().Take(count).Select(x => x as IStudent).ToList();
            ViewBag.Students = res;
            ViewData["success"] = "موفق";
            return View("Index");
        }

        public IActionResult Detail(int id) { 
            var queue = new MyQueue<Student>();
            queue.SetDefaultStudents();
            var res = queue.GetById(id);
            ViewBag.data = res;
            return View();
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
