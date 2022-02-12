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
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

       [TestMethod]
    public void PastryConstructor_AssignPriceToPastry_Int()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(2, newPastry.Price);
    }
  }
}