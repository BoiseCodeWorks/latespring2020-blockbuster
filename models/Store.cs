using System;
using System.Collections.Generic;
using BlockBuster.Interfaces;

namespace BlockBuster.Models
{
  public class Store : BaseEntity
  {
    public List<Movie> Movies { get; private set; }
    public List<IPurchaseable> ShoppingCart { get; set; }

    public Shop Shop { get; private set; }

    public Store(string title) : base(title)
    {
      Movies = new List<Movie>();
      Shop = new Shop();

    }

    public void Setup()
    {
      System.Console.WriteLine($"Welcome to {Title}!");
      Movie lotr = new Movie("Lord of The Rings");
      Movie donnieDarko = new Movie("Donnie Darko");
      Movies.Add(lotr);
      Movies.Add(donnieDarko);
      ShoppingCart = new List<IPurchaseable>();
      Item nickelBackCD = new Item("NickelBack CD", 1, 50.00m);
      Movie titanic = new Movie("Titanic");
      ShoppingCart.Add(nickelBackCD);
      ShoppingCart.Add(titanic);

      foreach (IPurchaseable cartItem in ShoppingCart)
      {
        cartItem.Purchase();
      }
    }

    public void VisitShop()
    {
      Shop.VisitShop();
    }

    internal void PrintMovies()
    {
      System.Console.WriteLine("Available Movies:");
      for (int i = 0; i < Movies.Count; i++)
      {
        Movie movie = Movies[i];
        if (movie.Available)
        {
          System.Console.WriteLine($"{i + 1} - {movie.Title}");
        }
      }
    }

    internal void PrintMovies(bool available)
    {
      System.Console.WriteLine("Rented Movies:");
      for (int i = 0; i < Movies.Count; i++)
      {
        Movie movie = Movies[i];
        if (movie.Available == available)
        {
          System.Console.WriteLine($"{i + 1} - {movie.Title}");
        }
      }
    }

    internal void RentMovie()
    {
      PrintMovies();
      System.Console.WriteLine("Which movie?");
      string input = Console.ReadLine();
      int index;
      if (int.TryParse(input, out index) != false && index - 1 < Movies.Count && index - 1 > -1)
      {
        Movie movie = Movies[index - 1];

        if (!movie.Available)
        {
          System.Console.WriteLine("That movie has already been rented!");
        }
        else
        {
          movie.Available = false;
          System.Console.WriteLine($"You rented {movie.Title}.");
        }
      }
      else
      {
        System.Console.WriteLine("Invalid Movie Index");
      }
    }

    internal void ReturnMovie()
    {
      PrintMovies(false);
      System.Console.WriteLine("Which movie?");
      string input = Console.ReadLine();
      int index;
      if (int.TryParse(input, out index) != false && index - 1 < Movies.Count && index - 1 > -1)
      {
        Movie movie = Movies[index - 1];

        if (movie.Available)
        {
          System.Console.WriteLine("That movie has already been returned!");
        }
        else
        {
          movie.Available = true;
          System.Console.WriteLine($"You returned {movie.Title}.");
        }
      }
      else
      {
        System.Console.WriteLine("Invalid Movie Index");
      }
    }
  }
}