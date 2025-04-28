using Microsoft.AspNetCore.Mvc;
using WebApp.Student.Data;


namespace WebApp.Student.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;   
        }
        public IActionResult Index()
        {
            var studentList = _context.Students.ToList();
            return View(studentList);
        }
    }
}
