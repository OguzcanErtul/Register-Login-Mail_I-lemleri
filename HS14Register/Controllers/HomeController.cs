using HS14Register.MailServices;
using HS14Register.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HS14Register.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMailService _mailService;
        private readonly UserManager<IdentityUser> _userManager;
        public HomeController(ILogger<HomeController> logger, IMailService mailService, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _mailService = mailService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Login", "Account");

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _userManager.FindByEmailAsync(model.Email);
                if (existingUser != null)
                {
                    TempData["DuplicateEmail"] = "This email address is already registered.";
                    return View(model);
                }

                var user = new IdentityUser { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user, "Password+9");
                if (result.Succeeded)
                {
                    var confirmCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var url = Url.Action("ConfirmEmail", "Home", new { userId = user.Id, code = confirmCode }, protocol: Request.Scheme);
                    var mailbody = $"Lütfen hesabınızın onaylanması için linke tıklayınız <br/> Şifreniz:'Password+9' <br/> <a href='{url}'>Buraya Tıkla</a>";
                    await _mailService.SendMailAsync(model.Email, "Üyelik İşlemleri", mailbody);
                    return RedirectToAction("Index", "Home");
                }
                Error();
            }
            return View(model);


        }
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return Error();
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (!result.Succeeded)
            {
                return Error();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}