using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Data;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Controllers
{
  public class CrustController : Controller
  {
    private PizzaBoxDbContext _db = new PizzaBoxDbContext();

    [HttpGet]
    public IActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Create(Crust crust)
    {

      if (ModelState.IsValid)
      {
        _db.Crusts.Add(crust);
        _db.SaveChanges();

        return RedirectToAction("Read");
      }

      return View();
    }

    public ViewResult Read()
    {
      return View(_db.Crusts.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult Update(int id)
    {
      return View(_db.Crusts.Single(c => c.Id == id));
    }

    [HttpPut]
    public IActionResult Update(Crust crust)
    {
      var res = _db.Crusts.Single(c => c.Id == crust.Id);

      res.Name = crust.Name;
      res.Price = crust.Price;

      _db.Attach(res);
      _db.SaveChanges();

      var res1 = _db.Entry<Crust>(new Crust());
      res1.State = EntityState.Added;

      _db.SaveChanges();

      return RedirectToAction("Read");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Crust crust)
    {
      _db.Crusts.Remove(_db.Crusts.Single(c => c.Id == crust.Id));

      return RedirectToAction("Read");
    }
  }
}