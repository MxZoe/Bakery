using System.Collections.Generic;


namespace Bakery.Models
{
  public class Bread
  {
    public int Price {get; set;}
    public int Quantity {get; set;}
    public int Total {get; set;}

    public Bread (int price, int quantity)
    {
      Price = price;
      Quantity = quantity;
      CalculateTotal();
    }

    public void CalculateTotal()
    {
      for(int i = 1; i <= Quantity; i++)
      {
        if(i % 3 == 0)
        {
          Total += 0;
        } 
        else
        {
          Total += Price;
        }
      }
    }
  }
}