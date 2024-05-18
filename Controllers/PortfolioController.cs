using Microsoft.AspNetCore.Mvc;

namespace LoginPage2.Controllers
{
	public class PortfolioController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
