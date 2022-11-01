using Microsoft.AspNetCore.Mvc;

namespace assigmentMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Contact() 
        { 
            return View(); 
        }
    }
}
