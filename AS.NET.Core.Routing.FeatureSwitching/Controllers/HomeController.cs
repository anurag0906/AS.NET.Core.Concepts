using AS.NET.Core.Routing.FeatureSwitching.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AS.NET.Core.Routing.FeatureSwitching.Controllers
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

		[Route("mycontact", Name ="contactroute")]
		public IActionResult Contact()
		{
			return View();
		}

		[Route("Email")]
		public IActionResult Email()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}