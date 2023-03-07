using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Controllers
{
  public class TypesController : Controller
  {
    private readonly AnimalShelterContext _db;

    public TypesController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Type> model = _db.Types.ToList();
      return View(model);
    }
  }
}