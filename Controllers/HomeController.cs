using Microsoft.AspNetCore.Mvc;

namespace LoginPage2.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
