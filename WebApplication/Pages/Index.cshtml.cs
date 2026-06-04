using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages;

public class IndexModel : PageModel
{
    private readonly IConfiguration _config;
    public IndexModel(IConfiguration config)
    {
        _config = config;
    }
}
