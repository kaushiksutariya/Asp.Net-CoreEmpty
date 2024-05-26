using Microsoft.AspNetCore.Mvc;

namespace AspCoreWebAppEmpty.Controllers
{
    public class UserController : Controller
    {
        [Route("controller")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
