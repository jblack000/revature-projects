using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Domain.Models
{
  public class PizzaSubmitForm
  {
    public int Id { get; set; }
    public int SelectedCrustId { get; set; }
    public int SelectedSizeId { get; set; }
    [NotMapped]
    public List<int> SelectedToppingId { get; set; }
  }
}