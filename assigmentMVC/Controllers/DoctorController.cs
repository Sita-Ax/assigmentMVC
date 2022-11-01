using Microsoft.AspNetCore.Mvc;

namespace assigmentMVC.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
