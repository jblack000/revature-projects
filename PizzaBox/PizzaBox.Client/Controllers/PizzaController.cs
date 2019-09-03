using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Data;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Controllers
{
  public class PizzaController : Controller
  {
    private PizzaBoxDbContext _db = new PizzaBoxDbContext();


    public IActionResult Index()
    {
      ViewBag.crust = _db.Crusts.ToList();
      ViewBag.size = _db.Sizes.ToList();
      ViewBag.topping = _db.Toppings.ToList();
      return View(new PizzaSubmitForm());
    }

    [HttpPost]
    public IActionResult Submit(PizzaSubmitForm submitform)
    {
      
      _db.Pizzas.Add(submitform);
      _db.SaveChanges();
      return View();
    }
    [HttpGet]
    public IActionResult Submit()
    {
      return View();
    }

  }
}