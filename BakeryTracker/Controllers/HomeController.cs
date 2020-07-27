using Microsoft.AspNetCore.Mvc;
using BakeryTracker.Models;

namespace BakeryTracker.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      Order starterOrder = new Order("01/01/2020", "2 loaves of sourdough", 6);
      return View(starterOrder);
    }

  }
}