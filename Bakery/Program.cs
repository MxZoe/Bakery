using Bakery.Models;
using System;


namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Greeting();
      GetOrder();
    }

    public static void Greeting(){
      Console.WriteLine("             ================");
      Console.WriteLine("             ||Zoe's Bakery||");
      Console.WriteLine("             ================");
      Console.WriteLine("............Welcome to my bakery!.............");
      Console.WriteLine(".......Bread is $5 or buy 2 get 1 free........");
      Console.WriteLine("Pastries are $2 or buy 2 get 50% of the third.");
    }
    public static void GetOrder()
    {
      int breadQuantity = 0;
      int pastryQuantity = 0;

      Console.WriteLine("How many loafs of bread would you like?");
      breadQuantity = Int32.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      pastryQuantity = Int32.Parse(Console.ReadLine());
      
      Bread newBread = new Bread(5, breadQuantity);
      Pastry newPastry = new Pastry (2, pastryQuantity);

      int totalAll = newPastry.Total + newBread.Total;

      Console.WriteLine(newBread.Quantity + " loafs:    $" + newBread.Total);
      Console.WriteLine(newPastry.Quantity + " pastries: $" + newPastry.Total);
      Console.WriteLine("---------------");
      Console.WriteLine("Total: $" + totalAll);
    }
  }
}