using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class MyMVCController : Controller
    {
        // GET: MyMVC/Welcome
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}
