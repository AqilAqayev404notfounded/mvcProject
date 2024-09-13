using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvcProject.DataAccsessLayer;

namespace mvcProject.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {

            var teachers = await _context.Teachers.ToListAsync();
            return View(teachers);
        }
    }
}
