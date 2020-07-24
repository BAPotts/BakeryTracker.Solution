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
  }
}