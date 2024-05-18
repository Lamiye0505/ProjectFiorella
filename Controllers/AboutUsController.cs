using Microsoft.AspNetCore.Mvc;

namespace LoginPage2.Controllers
{
	public class AboutUsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
