using System.Collections.Generic;


namespace Bakery.Models
{
  public class Pastry
  {
    public int Price {get; set;}
    public Pastry(int price)
    {
      Price = price;
    }
  }
}