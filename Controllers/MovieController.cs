using Microsoft.AspNetCore.Mvc;

namespace Movie_database_MVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
