using aspDotNet.EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using aspDotNet.PresentationLayer.Models;

namespace aspDotNet.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<appUser> _signInManager;
        private readonly UserManager<appUser> _userManager;

		public LoginController(SignInManager<appUser> signInManager, UserManager<appUser> userManager)
		{
			_signInManager = signInManager;
			_userManager = userManager;
		}

        [HttpGet]
		public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public async Task<IActionResult> Index(loginViewModel loginViewModel)
		{
			var result = await _signInManager.PasswordSignInAsync(loginViewModel.Username, loginViewModel.Password,false,true);
			
			if (result.Succeeded)
			{
				var user = await _userManager.FindByNameAsync(loginViewModel.Username);

				if (user.EmailConfirmed == true)
				{
					return RedirectToAction("Index", "MyProfile");
				}
			}

			return View();
		}
	}
}
