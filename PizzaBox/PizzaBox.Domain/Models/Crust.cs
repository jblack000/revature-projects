using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Domain.Models
{
  public class Crust
  {
    public int Id { get; set; }


    public string Name { get; set; }
    public decimal Price { get; set; }

    public List<Bread> Bread { get; set; }

    [NotMapped]
    public List<string> ViewBread { get; set; }
  }
}