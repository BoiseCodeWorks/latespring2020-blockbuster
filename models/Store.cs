using System;
using System.Collections.Generic;

namespace BlockBuster.Models
{
  public class Store
  {
    public List<Movie> Movies { get; private set; }

    public string Title { get; private set; }

    public Store(string title)
    {
      Title = title;
      Movies = new List<Movie>();
    }

    public void Setup()
    {
      System.Console.WriteLine($"Welcome to {Title}!");
      Movie lotr = new Movie("Lord of The Rings");
      Movie donnieDarko = new Movie("Donnie Darko");
      Movies.Add(lotr);
      Movies.Add(donnieDarko);
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