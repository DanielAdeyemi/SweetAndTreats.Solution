using Microsoft.AspNetCore.Mvc;

namespace SweetAndTreat.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}