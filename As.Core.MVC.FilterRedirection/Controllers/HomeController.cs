using As.Core.MVC.FilterRedirection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace As.Core.MVC.FilterRedirection.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[HttpGet]
		[MyRedirectionFilter(Action= "SomeAction", Controller = "Home")]
		public IActionResult UsePostman()
		{
			return Content("from Use Postman method"); ;
		}

		//on action executed will not get called here
		public IActionResult SomeAction()
		{
			return Content("response from some other action method");
		}
	}
}