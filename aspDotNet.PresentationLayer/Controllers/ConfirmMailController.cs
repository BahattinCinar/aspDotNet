using aspDotNet.EntityLayer.Concrate;
using aspDotNet.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace aspDotNet.PresentationLayer.Controllers
{
	public class ConfirmMailController : Controller
	{
		private readonly UserManager<appUser> _userManager;

        public ConfirmMailController(UserManager<appUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
		public IActionResult Index()
		{
            var value = TempData["Mail"];
            ViewBag.v = value;
			return View();
		}

		[HttpPost]
        public async Task<IActionResult> Index(ConfirmMailViewModel confirmMailViewModel)
        {
            var user = await _userManager.FindByEmailAsync(confirmMailViewModel.Mail);

            if(user.appUserConfirmCode == confirmMailViewModel.confirmCode)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index","Login");
            }

            return View();
        }
    }
}
