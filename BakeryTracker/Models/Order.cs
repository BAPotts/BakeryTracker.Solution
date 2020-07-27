using System.Collections.Generic;

namespace BakeryTracker.Models
{

  public class Order
  {
    public string Date { get; set;}
    public string Description { get; set; }
    public int Price { get; set; }
    private static List<Order> _instances = new List<Order> {};
    public Order(string date, string description, int price)
    {
    Date = date;
    Description = description;
    Price = price;
    _instances.Add(this);
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
  }
}