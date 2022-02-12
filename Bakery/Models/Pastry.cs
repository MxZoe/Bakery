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
      CalculateTotal();
    }

    public void CalculateTotal()
    {
      for(int i = 1; i <= Quantity; i++)
      {
        if(i % 3 == 0){
          Total += 1;
        }
        else
        {
          Total += Price;
        }
      }
    }
  }
}