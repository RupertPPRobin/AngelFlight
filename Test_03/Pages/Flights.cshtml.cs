using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test_03.Pages;

public class FlightsModel : PageModel
{
    private readonly ILogger<FlightsModel> _logger;

    public FlightsModel(ILogger<FlightsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
        ViewData["TimeStamp"] = dateTime;
    }
}


