using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvcProject.DataAccsessLayer;

namespace mvcProject.Controllers;

public class StudentController : Controller
{
    private readonly AppDbContext _context;

    public StudentController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {

        var students=await _context.Students.ToListAsync();
        return View(students);
    }
}
