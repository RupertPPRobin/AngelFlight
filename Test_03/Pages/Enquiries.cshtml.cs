using System.Globalization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test_03.Pages;

public class EnquiriesModel : PageModel
{
    private readonly ILogger<EnquiriesModel> _logger;

    public EnquiriesModel(ILogger<EnquiriesModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
        ViewData["TimeStamp"] = dateTime;
    }
}


