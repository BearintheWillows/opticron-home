using Microsoft.AspNetCore.Mvc;
using optricon_home.Models;
using System.Diagnostics;

namespace optricon_home.Controllers;
using Services;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IContentService _contentService;

    public HomeController( ILogger<HomeController> logger, IContentService contentService )
    {
        _logger = logger;
        _contentService = contentService;
    }

    public async Task<IActionResult> Index()
    {
        var content = await _contentService.GetContentAsync();
        return await Task.Run( () => View( content ) );

    }

   

    [ResponseCache( Duration = 0, Location = ResponseCacheLocation.None, NoStore = true )]
    public IActionResult Error()
    {
        return View( new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier } );
    }
}
