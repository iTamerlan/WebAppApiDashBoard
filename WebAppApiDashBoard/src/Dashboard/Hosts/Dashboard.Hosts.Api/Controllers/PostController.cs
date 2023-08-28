using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Hosts.Api.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
