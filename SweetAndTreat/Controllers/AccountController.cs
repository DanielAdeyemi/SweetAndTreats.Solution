using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using SweetAndTreat.Models;
using SweetAndTreat.ViewModels;

namespace SweetAndTreat.Controllers
{
  public class AccountController : Controller
  {
    private readonly SweetAndTreatContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, SweetAndTreatContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }
    public IActionResult Register()
    {
      return View();
    }
  }
}
