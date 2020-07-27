using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class OrderTest
  {
    [TestMethod]
    public void OrderConstructor_CreatesOrderObject_Order()
    {
      Order newOrder = new Order("test", "test", 1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string date = "7/24/2020";
      string description = "3 loaves of sourdough";
      int price = 9;
      Order newOrder = new Order(date, description, price);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

  }


  
}
