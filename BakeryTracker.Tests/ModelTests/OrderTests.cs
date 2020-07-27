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
    public void getProperties_ReturnsProperties_StringStringInt()
    {
      string date = "7/24/2020";
      string description = "3 loaves of sourdough";
      int price = 9;
      Order newOrder = new Order(date, description, price);
      string dateResult = newOrder.Date;
      string descripResult = newOrder.Description;
      int priceResult = newOrder.Price;
      Assert.AreEqual(date, dateResult);
      Assert.AreEqual(description, descripResult);
      Assert.AreEqual(price, priceResult);
    }
    [TestMethod]
    public void setProperties_setProperties_StringStringInt()
    {
      Order newOrder = new Order("12/05/2020","2 loaves", 1);

      //Act
      string updatedDate = "1/1/2021";
      newOrder.Date = updatedDate; 
      newOrder.Description = "1 loaf";
      newOrder.Price = 2;

      //Assert
      Assert.AreEqual("1/1/2021", newOrder.Date);
      Assert.AreEqual("1 loaf", newOrder.Description);
      Assert.AreEqual(2, newOrder.Price);
    }
    [TestMethod]
public void GetAll_ReturnsEmptyList_OrderList()
{
  // Arrange
  List<Order> newList = new List<Order> {};

  // Act
  List<Order> result = Order.GetAll();

  // Assert
  CollectionAssert.AreEqual(newList, result);
}


  }


  
}
