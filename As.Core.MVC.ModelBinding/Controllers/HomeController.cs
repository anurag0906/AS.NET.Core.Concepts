using As.Core.MVC.ModelBinding.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace As.Core.MVC.ModelBinding.Controllers
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

		[HttpGet]
		[Route("/contact-us", Name = "Contact")]
		public IActionResult Contact()
		{
			return View();
		}

		[HttpPost]
		[Route("/contact-us", Name = "Contact")]
		public IActionResult Contact([FromForm] Contact info)
		{
			// Contact logic

			return View(info);
		}

		
	}
}