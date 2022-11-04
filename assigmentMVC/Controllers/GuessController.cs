using Microsoft.AspNetCore.Mvc;

namespace assigmentMVC.Controllers
{
    public class GuessController : Controller
    {
        [HttpPost]
        public IActionResult GuessNumber(Random number)
        {
           
            ViewBag.Number = Models.Guess.RandomNumbers(number);
            return View();
        }

        [HttpGet]
        public IActionResult GuessNumber()
        {
            return View();
        }
    }
}
