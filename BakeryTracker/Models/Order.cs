

namespace BakeryTracker.Models
{

  public class Order
  {
    public string Date { get; }
    public string Description { get; }
    public int Price { get; }
    public Order(string date, string description, int price)
    {
    Date = date;
    Description = description;
    Price = price +1;
    }
  }
}