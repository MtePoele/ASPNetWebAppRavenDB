using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNetWebAppRavenDB.Pages
{
    public class AlpineModel : PageModel
    {
        private readonly ILogger<AlpineModel> _logger;

        public AlpineModel(ILogger<AlpineModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
