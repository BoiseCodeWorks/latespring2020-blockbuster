using BlockBuster.Interfaces;

namespace BlockBuster.Models
{
  public class Item : BaseEntity, IPurchaseable
  {
    public int Quantity { get; set; }
    public decimal Price { get; private set; }

    public Item(string title, int quantity, decimal price) : base(title)
    {
      Quantity = quantity;
      Price = price;
    }

    public void Purchase()
    {
      System.Console.WriteLine($"Purchased {Title} foreeeever");
    }
  }
}