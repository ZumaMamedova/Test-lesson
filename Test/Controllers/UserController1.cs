using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
