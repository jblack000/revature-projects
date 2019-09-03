using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Data;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Controllers
{
  public class SizeController : Controller
  {
    private PizzaBoxDbContext _db = new PizzaBoxDbContext();

    [HttpGet]
    public IActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Create(Size size)
    {

      if (ModelState.IsValid)
      {
        _db.Sizes.Add(size);
        _db.SaveChanges();

        return RedirectToAction("Read");
      }

      return View();
    }

    public ViewResult Read()
    {
      return View(_db.Sizes.ToList());
    }
  }
}