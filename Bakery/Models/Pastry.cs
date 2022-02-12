using System.Collections.Generic;


namespace Bakery.Models
{
  public class Pastry
  {
    public int Price {get; set;}
    public int Quantity {get; set;}
    public int Total {get; set;}
    public Pastry(int price, int quantity)
    {
      Price = price;
      Quantity = quantity;
      Total = 0;
    }
  }
}