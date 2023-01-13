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

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor)
    {
      if (!ModelState.IsValid)
      {
        return View();
      }
      else
      {
      _db.Flavors.Add(flavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
      }
    }

    public ActionResult Details(int id)
    {
      Flavor thisFlavor = _db.Flavors
                                .Include(flavor => flavor.JoinEntities)
                                .ThenInclude(join => join.Treat)
                                .FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }

    public ActionResult Edit(int id)
    {
      Flavor thisFlavor = _db.Flavors
                            .Include(flavor => flavor.JoinEntities)
                            .ThenInclude(join => join.Treat)
                            .FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult Edit(Flavor flavor)
    {
      if (!ModelState.IsValid)
      {
        return View();
      }
      else
      {
      _db.Flavors.Update(flavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
      }
    }
  }
}