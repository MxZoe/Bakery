using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    // Test methods go here
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2, 5);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryConstructor_AssignPriceToPastry_Int()
    {
      Pastry newPastry = new Pastry(2, 5);
      Assert.AreEqual(2, newPastry.Price);
    }

    [TestMethod]
    public void PastryConstructor_AssignQuantityToPastry_Int()
    {
      Pastry newPastry = new Pastry(2, 5);
      Assert.AreEqual(5, newPastry.Quantity);
    }

    [TestMethod]
    public void PastryConstructor_SetTotalInPastryConstructor_Int()
    {
      Pastry newPastry = new Pastry(2, 6);
      Assert.AreEqual(0, newPastry.Total);
    }
  }
}