using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test_03.Pages;

public class PilotsModel : PageModel
{
    private readonly ILogger<PilotsModel> _logger;

    public PilotsModel(ILogger<PilotsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
        ViewData["TimeStamp"] = dateTime;
    }
}


