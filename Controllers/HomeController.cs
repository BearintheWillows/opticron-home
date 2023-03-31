using Microsoft.AspNetCore.Mvc;
using optricon_home.Models;
using System.Diagnostics;

namespace optricon_home.Controllers;

using System.Text.Encodings.Web;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController( ILogger<HomeController> logger )
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // List<string> orbitViewModel = null;
        // orbitViewModel.Add("<img src='images/Screenshot 2023-03-30 125113.png'` alt=''>");
        //
        return View();
    }

    public IActionResult Edit(string name = "World", int ID = 1)
    {
        ViewData["Message"] = "Your application description page.";
        ViewData["ID"] = ID;
        return View();
    }

    [ResponseCache( Duration = 0, Location = ResponseCacheLocation.None, NoStore = true )]
    public IActionResult Error()
    {
        return View( new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier } );
    }
}
