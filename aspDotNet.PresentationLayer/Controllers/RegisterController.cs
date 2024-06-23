using aspDotNet.DtoLayer.Dtos.appUserDtos;
using aspDotNet.EntityLayer.Concrate;
using Azure.Identity;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

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
                Random random = new Random();

                int code;

                code = random.Next(10000, 1000000);


				appUser appUser = new appUser()
                {
                    UserName = AppUserRegisterDto.dtoUserName,
                    appUserName = AppUserRegisterDto.dtoName,
                    appUserSurname = AppUserRegisterDto.dtoSurname,
                    Email = AppUserRegisterDto.dtoEmail,
                    appUserCity = "aaa",
                    appUserDistrict = "bbb",
					appUserImageUrl = "ccc",
                    appUserConfirmCode = code
                    

				};
                var result = await _userManager.CreateAsync(appUser, AppUserRegisterDto.dtoPassword);
                if (result.Succeeded)
                {
                    MimeMessage mimeMessage = new MimeMessage();
                    MailboxAddress mailboxAddressForm = new MailboxAddress("Asp.Ner Admin", "bahattin614@gmail.com");
                    MailboxAddress mailboxAddressTo = new MailboxAddress("User", appUser.Email);

                    mimeMessage.From.Add(mailboxAddressForm);
                    mimeMessage.To.Add(mailboxAddressTo);

                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.TextBody = "Kayit islemini gerceklestirmek icin onay kodunuz: " + code;

                    mimeMessage.Body = bodyBuilder.ToMessageBody();

                    mimeMessage.Subject = "asp.net Onay Kodu";

                    SmtpClient client = new SmtpClient();

                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("bahattin614@gmail.com", "rrhxqfvxolkqtuuz");
                    client.Send(mimeMessage);
                    client.Disconnect(true);


                    TempData["Mail"] = AppUserRegisterDto.dtoEmail;


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
