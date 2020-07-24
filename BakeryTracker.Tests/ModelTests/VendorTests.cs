using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]

  public class VendorTest 
  {

  [TestMethod]
    public void VendorConstructor_CreatesVendorObject_Vendor()
    {
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}