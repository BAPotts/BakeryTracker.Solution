using System.Collections.Generic;

namespace BakeryTracker.Models
{

  public class Vendor
  {
    public string Description {get; set;}
    private static List<Vendor> _instances = new List<Vendor>{};
    public string Name{get; set;}
    public int Id { get;}
    public Vendor(string description, string vendorName)
    {
      Description = description;
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}