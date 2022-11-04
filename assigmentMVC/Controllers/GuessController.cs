using Microsoft.AspNetCore.Mvc;

namespace assigmentMVC.Controllers
{
    public class GuessController : Controller
    {
        public IActionResult GuessNumber()
        {
            return View();
        }
    }
}
