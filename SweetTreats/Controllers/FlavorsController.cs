using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using SweetTreats.Models;
using System.Linq;
using System.Collections.Generic;

namespace SweetTreats.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly SweetTreatsContext _db;
    public FlavorsController(SweetTreatsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }
  }
}