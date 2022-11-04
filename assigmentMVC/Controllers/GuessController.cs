using Microsoft.AspNetCore.Mvc;

namespace assigmentMVC.Controllers
{
    public class GuessController : Controller
    {
        [HttpPost]
        public IActionResult GuessNumber(int guess)
        {  
            ViewBag.Number = Models.Guess.RandomNumbers(guess);
            return View();
        }

        [HttpGet]
        public IActionResult GuessNumber()
        {
            return View();
        }
    }
}
