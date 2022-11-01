using Microsoft.AspNetCore.Mvc;

namespace assigmentMVC.Controllers
{ 

    public class DemoController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PreferdLanguageCookie()
        {
            string? lang = Request.Cookies["PrefLang"];//read the cookie
            if (!string.IsNullOrEmpty(lang))
            {
                ViewBag.Lang = lang;
            }
            return View();
        }

        public IActionResult SetLanguageCookie(string lang)
        {

            if (!string.IsNullOrWhiteSpace(lang))
            {
                //Add cookie to Response object
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddMinutes(1);
                Response.Cookies.Append("PrefLang", lang, option);
            }
            return RedirectToAction(nameof(PreferdLanguageCookie));
        }
    }
}
