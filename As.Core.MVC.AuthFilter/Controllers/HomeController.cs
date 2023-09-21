using As.Core.MVC.AuthFilter.Models;
using As.Core.MVC.AuthFilter.MyFilter;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace As.Core.MVC.AuthFilter.Controllers;

[TypeFilter(typeof(OutageAuthorizationFilter))]// TypeFilter takes care of any dependency inside any filter
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


	[Route("Email")]
	public IActionResult Email()
	{
		return View();
	}

	[Route("outage")]
	public IActionResult Outage()
	{
		return View();
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}