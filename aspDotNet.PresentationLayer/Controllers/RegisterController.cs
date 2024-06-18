using aspDotNet.DtoLayer.Dtos.appUserDtos;
using aspDotNet.DtoLayer.Dtos.appUserDtos;
using aspDotNet.EntityLayer.Concrate;
using Azure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace aspDotNet.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<appUser> _userManager;

        public RegisterController(UserManager<appUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(appUserRegisterDto AppUserRegisterDto)
        {
            if (ModelState.IsValid)
            {
                appUser appUser = new appUser()
                {
                    UserName = AppUserRegisterDto.dtoUserName,
                    appUserName = AppUserRegisterDto.dtoName,
                    appUserSurname = AppUserRegisterDto.dtoSurname,
                    Email = AppUserRegisterDto.dtoEmail
                };
                var result = await _userManager.CreateAsync(appUser, AppUserRegisterDto.dtoPassword);
                if (result.Succeeded)
                { 
                    return RedirectToAction("Index", "ConfirmMail");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
    }
}
