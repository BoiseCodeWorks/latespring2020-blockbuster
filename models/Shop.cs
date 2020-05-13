using System;
using System.Collections.Generic;

namespace BlockBuster.Models
{
  public class Shop : BaseEntity
  {
    public List<Item> Inventory { get; private set; } = new List<Item>();

    public Shop() : base("D$ shop")
    {
      Item paydayCandyBar = new Item("PayDay CandyBar", 10, 2.00m);
      Item popcorn = new Item("Bag of Popcorn", 5, 3.00m);
      Item mountainDew = new Item("Mountain Dew 2 Liter", 100, 1.25m);
      Inventory.Add(paydayCandyBar);
      Inventory.Add(popcorn);
      Inventory.Add(mountainDew);
    }

    internal void VisitShop()
    {
      System.Console.WriteLine("Welcome to the shop, take a look around, get what you need.");
      PrintItems();
      bool purchasing = true;
      while (purchasing)
      {
        System.Console.WriteLine("Type in the item you want, or type \"leave\" to exit the shop.");
        string input = Console.ReadLine();
        if (input.ToLower() == "leave")
        {
          System.Console.WriteLine("Thanks for shopping");
          purchasing = false;
        }
        else
        {
          PurchaseItem(input);
        }
      }
    }

    private void PurchaseItem(string itemName)
    {
      Item foundItem = Inventory.Find(item => item.Title.ToLower() == itemName.ToLower());
      if (foundItem != null)
      {
        if (foundItem.Quantity < 1)
        {
          System.Console.WriteLine($"There aren't any {foundItem.Title} left.");
          return;
        }
        foundItem.Quantity--;
        System.Console.WriteLine($"You purchased {foundItem.Title} for {foundItem.Price} there are {foundItem.Quantity} left.");
      }
      else
      {
        System.Console.WriteLine($"Couldn't find {itemName}");
      }
    }

    private void PrintItems()
    {
      System.Console.WriteLine("Available Items:");
      for (int i = 0; i < Inventory.Count; i++)
      {
        Item item = Inventory[i];
        if (item.Quantity > 0)
        {
          System.Console.WriteLine($"{i + 1} - {item.Title} Qty: {item.Quantity} ${item.Price} Each");
        }
      }
    }
  }
}
