using BlockBuster.Interfaces;

namespace BlockBuster.Models
{
  public class Movie : BaseEntity, IPurchaseable
  {
    public bool Available { get; set; }
    public decimal Price { get; private set; }
    public Movie(string title) : base(title)
    {
      Available = true;
    }

    public void Purchase()
    {
      System.Console.WriteLine($"Purchased {Title} for 3 days");
    }
  }
}