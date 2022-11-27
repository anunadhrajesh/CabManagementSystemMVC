using CabManagementSystem.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CabManagementSystem.Areas.Accounts.Controllers
{
    [Area("Accounts")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public HomeController(
            ApplicationDbContext db,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid details");
                return View(model);
            }

            var res = await _signInManager.PasswordSignInAsync(user, model.Password, true, true);

            if (res.Succeeded)
            {
                //return RedirectToAction("Index", "Home", new {Area=""});
                return Redirect("/");
            }
            return View(model);
        }






        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new ApplicationUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = Guid.NewGuid().ToString().Replace("-", "")
            };

            var res = await _userManager.CreateAsync(user, model.Password);

            if (res.Succeeded)
                return RedirectToAction(nameof(Index));

            ModelState.AddModelError("", "An Error Occoured");
            return View(model);
        }
    }
}
