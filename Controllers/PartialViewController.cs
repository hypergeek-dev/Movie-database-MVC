using Microsoft.AspNetCore.Mvc;

namespace Movie_database_MVC.Controllers
{
    public class PartialViewController : Controller
    {
        public IActionResult MovieCreatePartial()
        {
            return PartialView("_MovieCreatePartial");
        }
    }
}