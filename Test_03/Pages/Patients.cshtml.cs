using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test_03.Pages;

public class PatientsModel : PageModel
{
    private readonly ILogger<PatientsModel> _logger;

    public PatientsModel(ILogger<PatientsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
        ViewData["TimeStamp"] = dateTime;
    }
}


