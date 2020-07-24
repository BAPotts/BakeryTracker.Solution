using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]

  public class VendorTests
  {

  [TestMethod]
    public void VendorConstructor_CreatesVendorObject_Vendor()
    {
      Vendor newVendor = new Vendor("test string");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    { //Arrange
      string description = "Pizza place in Royal Oak";
      Vendor newVendor = new Vendor(description);
      //Act
      string result = newVendor.Description;
      //Assert
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {

      //Arrange
      string description = "Pizza place in Royal Oak";
      Vendor newVendor = new Vendor(description);

      //Act
      string updatedDescription = "Tapas restaurant in Detroit";
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }
  }
}