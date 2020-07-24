using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]

  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

  [TestMethod]
    public void VendorConstructor_CreatesVendorObject_Vendor()
    {
      Vendor newVendor = new Vendor("test string", "test string");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    { //Arrange
      string description = "Pizza place in Royal Oak";
      Vendor newVendor = new Vendor(description, "test string");
      //Act
      string result = newVendor.Description;
      //Assert
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {

      //Arrange
      string name = "Pedros";
      string description = "Pizza place in Royal Oak";
      Vendor newVendor = new Vendor(description, name);

      //Act
      
      string updatedDescription = "Tapas restaurant in Detroit";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name1 = "HoneyBee";
      string descrip1 = "HoneyBee Market in Detroit";
      string name2 = "PapasCafe";
      string descrip2 = "Papa's Cafe in Berkley";
      Vendor newVendor = new Vendor(descrip1, name1);
      Vendor newVendor2 = new Vendor(descrip2, name2);
      List<Vendor> newList = new List<Vendor>{newVendor, newVendor2};
      //Act
      List<Vendor> result = Vendor.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      //Arrange
      string name = "Test";
      string descrip = "descrip";
      Vendor newVendor = new Vendor(descrip, name);

      //Act
      int result = newVendor.Id;
      //Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void  Find_ReturnsCorrectVendor_Vendor()
    {
       //Arrange
      string name1 = "HoneyBee";
      string descrip1 = "HoneyBee Market in Detroit";
      string name2 = "PapasCafe";
      string descrip2 = "Papa's Cafe in Berkley";
      Vendor newVendor = new Vendor(descrip1, name1);
      Vendor newVendor2 = new Vendor(descrip2, name2);
      //Act
      Vendor result = Vendor.Find(2);
      //Assert
      Assert.AreEqual(newVendor2, result);
    }
  }
}