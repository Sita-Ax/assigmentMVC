using assigmentMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace assigmentMVC.Controllers
{
    public class DoctorController : Controller
    {
        [HttpPost]
        public IActionResult FeverCheck(double temp)
        {
            if (temp != 0)
            {
                ViewBag.Msg = Models.Doctor.Diagnose(temp);
                return View();
            }
            else
            {
                ViewBag.Msg = "Enter your temperature here plizz.";
                return View();
            }
        }

        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult TempSelect(Doctor doctor)
        //{
        //    if (doctor != null)
        //    {
        //        ViewBag.Celsius = doctor.Celisius.ToString();
        //        ViewBag.Fahrenhigt = doctor.Fahrenhigt.ToString();
        //        return View();
        //    }
        //        return View();
        //}
    }
}
