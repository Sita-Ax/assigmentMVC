using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace assigmentMVC.Controllers
{
    public class GuessController : Controller
    {
        Random random = new();

        [HttpPost]
        public IActionResult GuessNumber(int guess)
        {
            //to read cookie
            string? randomNr = Request.Cookies["random"];
            int rand;
            if (randomNr == null)
            {
                //add cookie
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddMinutes(10);

                int r = random.Next(0, 100);
                Response.Cookies.Append("random", r.ToString(), options);
                rand = r;
            }
            else
            {
                rand = int.Parse(randomNr);
            }
            ViewBag.Number = Models.Guess.RandomNumbers(guess, rand);
            return View();
        }
        


        [HttpGet]
        public IActionResult GuessNumber()
        {
            string? randomNr = Request.Cookies["random"];

            if (randomNr == null)
            {
                //remove cookie
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddDays(-1);
               
                random.Next(0, 100);
                Response.Cookies.Append("random", "", option);
            }
            return View();
        }
        
    }
}
