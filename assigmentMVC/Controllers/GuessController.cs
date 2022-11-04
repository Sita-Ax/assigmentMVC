using Microsoft.AspNetCore.Mvc;

namespace assigmentMVC.Controllers
{
    public class GuessController : Controller
    {
        [HttpPost]
        public IActionResult GuessNumber(int guess)
        {
            if (guess != 0)
            {
                ViewBag.Number = Models.Guess.RandomNumbers(guess);
                return View();
            } else
            {
                ViewBag.Number = "Please enter a number";
                return View();
            }
        }

        //public IActionResult NumberSession()
        //{
        //    Random rand = new Random();
        //    string? randomNr = Convert.ToInt32(Request.Cookies["random"]);
        //}

        [HttpGet]
        public IActionResult GuessNumber()
        {
            return View();
        }
    }
}
