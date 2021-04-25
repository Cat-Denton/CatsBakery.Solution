using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CatsBakery.Models;

namespace CatsBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadOrderSize_ReturnsBreadOrderSize_int()
    {
      int breadOrderSize = 5;
      Bread newBread = new Bread(5);
      int result = newBread.BreadOrderSize;
      Assert.AreEqual(breadOrderSize,result);
    }

    [TestMethod]
    public void GetBreadDiscount_ReturnDiscountLessThan3_0()
    {
    int breadDiscount = 0;
    Bread newBread = new Bread(2);
    int result = newBread.GetBreadDiscount();
    Assert.AreEqual(breadDiscount, result);
    }

    [TestMethod]
    public void GetBreadDiscount_ReturnDiscountThreeBread_1()
    {
    int breadDiscount = 1;
    Bread newBread = new Bread(3);
    int result = newBread.GetBreadDiscount();
    Assert.AreEqual(breadDiscount, result);
    }
  }
}