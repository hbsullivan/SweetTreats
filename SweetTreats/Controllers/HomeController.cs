using Microsoft.AspNetCore.Mvc;
using SweetTreats.Models;
using System.Collections.Generic;
using System.Linq;

namespace SweetTreats.Controllers
{
  public class HomeController : Controller
  {
    private readonly SweetTreatsContext _db;
    public HomeController(SweetTreatsContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      Flavor[] fla = _db.Flavors.ToArray();
      Treat[] tre = _db.Treats.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("flavors", fla);
      model.Add("treats", tre);
      return View(model);
    }
  }
}