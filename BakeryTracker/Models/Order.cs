using System.Collections.Generic;

namespace BakeryTracker.Models
{

  public class Order
  {
    public string Date { get; set;}
    public string Description { get; set; }
    public int Price { get; set; }
    public int Id {get; }
    private static List<Order> _instances = new List<Order> {};
    public Order(string date, string description, int price)
    {
      Date = date;
      Description = description;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count+1;
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}