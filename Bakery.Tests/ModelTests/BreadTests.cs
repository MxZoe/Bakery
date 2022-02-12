using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    // Test methods go here
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5, 3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_AssignPriceToBread_Int()
    {
      Bread newBread = new Bread(5, 3);
      Assert.AreEqual(5, newBread.Price);
    }

    [TestMethod]
    public void BreadConstructor_AssignQuantityToBread_Int()
    {
      Bread newBread = new Bread(5, 3);
      Assert.AreEqual(3, newBread.Quantity);
    }
     [TestMethod]
    public void BreadConstructor_AssignTotalToBread_Int()
    {
      Bread newBread = new Bread(5, 3);
      Assert.AreEqual(15, newBread.Total);
    }
  }
}