

namespace BakeryTracker.Models
{

  public class Order
  {
    public string Date { get; set;}
    public string Description { get; set; }
    public int Price { get; set; }
    public Order(string date, string description, int price)
    {
    Date = date;
    Description = description;
    Price = price;
    }
  }
}