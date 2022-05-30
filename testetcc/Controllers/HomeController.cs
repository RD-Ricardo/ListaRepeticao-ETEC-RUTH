using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using testetcc.Models;
using Microsoft.AspNetCore.Http.Extensions;

namespace testetcc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var url = HttpContext.Request.GetEncodedUrl();
        
        ViewData["teste"] =  url;

        return View();
    }

    public IActionResult Privacy()
    {
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
