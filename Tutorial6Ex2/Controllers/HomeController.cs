using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tutorial6Ex2.Models;

namespace Tutorial6Ex2.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult about()
    {
        return View();
    }
    public IActionResult services()
    {
        return View();
    }

    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
