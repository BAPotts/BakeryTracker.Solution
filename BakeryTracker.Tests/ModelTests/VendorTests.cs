using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vendor.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.TestTools
{
  [TestClass]

  public class VendorTest : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    public void VendorConstructor_CreatesVendorObject_Vendor()
    {
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
  }
}