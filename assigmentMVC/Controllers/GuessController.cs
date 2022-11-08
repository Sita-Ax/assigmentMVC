using assigmentMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace assigmentMVC.Controllers
{
    public class GuessController : Controller
    {
        [HttpPost]
        public IActionResult GuessNumber(int guess)
        {
            if (!(string.IsNullOrEmpty(HttpContext.Session.GetString("random")) || guess <= 0 || guess >= 100))
            {
                int rand = (int)HttpContext.Session.GetInt32("random");
                if(rand == 0)
                {
                    return NotFound();
                }
                string respons = Guess.RandomNumbers(Convert.ToInt32(guess), rand);
                ViewBag.Msg = respons;
            }
            else
            {
                ViewBag.Msg = "Enter a number between 1 and 100 and Submit";
            }
            return View();
        }

        [HttpGet]
        public IActionResult GuessNumber()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("random")))
            {
                int getRand = Guess.GetRandom();
                HttpContext.Session.SetInt32("random", getRand);
                ViewBag.Number = getRand;
            }
            else
            {
                ViewBag.Number = HttpContext.Session.GetInt32("random");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Reset()
        {
            int getRand = Guess.GetRandom();
            HttpContext.Session.SetInt32("random", getRand);
            ViewBag.Number = getRand;
            return RedirectToAction(nameof(GuessNumber));
        }
    }
}

//Random random = new();

//[HttpPost]
//public IActionResult GuessNumber(int guess)
//{
//    //to read cookie
//    string? randomNr = Request.Cookies["random"];
//    int rand;
//    if (randomNr == null)
//    {
//        //add cookie
//        CookieOptions options = new CookieOptions();
//        options.Expires = DateTime.Now.AddMinutes(10);

//        int r = random.Next(0, 100);
//        Response.Cookies.Append("random", r.ToString(), options);
//        rand = r;
//    }
//    else
//    {
//        rand = int.Parse(randomNr);
//    }
//    ViewBag.Number = Models.Guess.RandomNumbers(guess, rand);
//    return View();
//}

//[HttpGet]
//public IActionResult GuessNumber()
//{
//    string? randomNr = Request.Cookies["random"];
//    if (randomNr == null)
//    {
//        //remove cookie
//        CookieOptions option = new CookieOptions();
//        option.Expires = DateTime.Now.AddDays(-1);

//        random.Next(0, 100);
//        Response.Cookies.Append("random", "", option);
//    }
//    return View();
//}