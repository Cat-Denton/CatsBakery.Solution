using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CatsBakery.Models;

namespace CatsBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(8);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryOrderSize_ReturnsPastryORderSize_Int()
    {
      int pastryOrderSize = 8;
      Pastry newPastry = new Pastry(8);
      int result = newPastry.PastryOrderSize;
      Assert.AreEqual(pastryOrderSize, result);
    }

    [TestMethod]
    public void GetPastryDiscount_ReturnDiscountLessThanThree_0()
    {
      int pastryDiscount = 0;
      Pastry newPastry = new Pastry(2);
      int result = newPastry.GetPastryDiscount();
      Assert.AreEqual(pastryDiscount,result);
    }
  }
}