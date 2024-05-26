using Microsoft.AspNetCore.Mvc;

namespace AspCoreWebAppEmpty.Controllers
{
    //called token [controller]/[action]
    [Route("[controller]/[action]")]
    //[Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]
        //[Route("Home")]
        //[Route("Home/Index")]
        //[Route("Index")]
        //[Route("[action]")]
        [Route("~/")]
        [Route("~/Home")]


        public IActionResult Index()
        {
            return View();
        }
        //[Route("Home/About")]
        //[Route("About")]
        //[Route("[action]")]

        public IActionResult About()
        {
            return View();
        }
        //[Route("Home/Details/{id?}")]
        //[Route("Details/{id?}")]
        //[Route("[action]")]

        public int Details(int? id)
        {
            return id ?? 1;// ?? mnull collas then 1
        }
    }
}
