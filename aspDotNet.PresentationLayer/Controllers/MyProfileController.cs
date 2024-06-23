using Microsoft.AspNetCore.Mvc;

namespace aspDotNet.PresentationLayer.Controllers
{
    public class MyProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
