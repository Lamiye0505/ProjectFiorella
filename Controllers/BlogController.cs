﻿using Microsoft.AspNetCore.Mvc;

namespace LoginPage2.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
