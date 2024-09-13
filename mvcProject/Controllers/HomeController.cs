using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace mvcProject.Controllers
{
    public class HomeController : Controller
    {

      

        public IActionResult Index()
        {
            return View();
        }

       
    }
}
