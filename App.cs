using System;
using BlockBuster.Models;

namespace BlockBuster
{
  public class App
  {
    public Store Store { get; set; }
    public bool Running { get; private set; }

    public void Run()
    {
      Store = new Store("BlockBuster");
      Console.Clear();
      Store.Setup();
      Running = true;

      while (Running)
      {
        MakeSelection();
      }

    }

    private void MakeSelection()
    {
      System.Console.WriteLine("What would you like to do? Rent / Return / Shop / Quit");
      string choice = Console.ReadLine();
      switch (choice.ToLower())
      {
        case "rent":
          Store.RentMovie();
          break;
        case "quit":
          Running = false;
          System.Console.WriteLine("Thanks for visiting come back soon!");
          Console.ReadLine();
          break;
        case "return":
          Store.ReturnMovie();
          break;
        case "shop":
          Store.VisitShop();
          break;
        default:
          System.Console.WriteLine("Invalid Selection");
          break;
      }
    }
  }
}
