using Microsoft.AspNetCore.Mvc;

namespace RZA___Riget_Zoo_Adventures.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
