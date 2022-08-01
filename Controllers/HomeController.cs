using Microsoft.AspNetCore.Mvc;

namespace walletinout.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {

    }

    public IActionResult Index()
    {
        return View();
    }


}
