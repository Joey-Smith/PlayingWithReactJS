using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class SignalRController : Controller
    {
        public IActionResult Chat()
        {
            return View();
        }
    }
}
