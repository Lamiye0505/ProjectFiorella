using LoginPage2.Entities;
using LoginPage2.VIewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LoginPage2.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<User> _userManager;
		private readonly SignInManager<User> _signInManager;

		public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Register(AccountRegisterViewModel model)
		{
			if (!ModelState.IsValid) return View();

			var user = new User
			{
				Email = model.Email,
				UserName = model.Username,
				FullName = model.Fullname,
			};

			var result = await _userManager.CreateAsync(user, model.Password);
			if (!result.Succeeded)
			{
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(string.Empty, error.Description);
				}
				return View();
			}

			return RedirectToAction(nameof(Login));
		}


		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Login(AccountLoginViewModel model)
		{
			if (!ModelState.IsValid) return View();

			var user = await _userManager.FindByEmailAsync(model.Email);
			if (user == null)
			{
				ModelState.AddModelError(string.Empty, "Email or Password is not correct");
				return View();
			}

			var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
			if (!result.Succeeded)
			{
				ModelState.AddModelError(string.Empty, "Email or Password is not correct");
				return View();
			}

			return Content("Login is successfull");
		}
	}

}
