using Microsoft.AspNetCore.Mvc;

namespace HospitalWeb.Areas.Patient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
