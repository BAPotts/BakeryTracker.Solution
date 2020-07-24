using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]

  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
  }
}
