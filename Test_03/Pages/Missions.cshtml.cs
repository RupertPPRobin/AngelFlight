using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test_03.Pages;

public class MissionsModel : PageModel
{
    private readonly ILogger<MissionsModel> _logger;

    public MissionsModel(ILogger<MissionsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
        ViewData["TimeStamp"] = dateTime;
    }
}


