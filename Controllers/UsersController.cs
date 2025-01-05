using Microsoft.AspNetCore.Mvc;

namespace SdRashaGYMV2.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
