using Microsoft.AspNetCore.Mvc;

namespace LoginPage2.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
