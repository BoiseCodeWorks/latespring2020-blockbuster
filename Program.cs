using System;

namespace BlockBuster
{
  class Program
  {

    // public enum Choice { Rock, Paper, Scissors }
    // public enum Result { Win, Lose, Draw }
    static void Main(string[] args)
    {
      App app = new App();
      app.Run();
      //   Random rnd = new Random();
      //   while (true)
      //   {
      //     System.Console.WriteLine("Choose 0. Rock, 1. Paper, 2. Scissors or Q to quit");
      //     string input = Console.ReadLine().ToLower();
      //     if (input == "q" || input == "quit")
      //     {
      //       System.Console.WriteLine("Thanks for playing!");
      //       return;
      //     }
      //     if (!Enum.TryParse(input, out Choice playerChoice))
      //     {
      //       System.Console.WriteLine("Invalid Choice");
      //       continue;
      //     }
      //     Choice computerChoice = (Choice)rnd.Next(0, 3);
      //     System.Console.WriteLine($"Computer chose {computerChoice}");
      //     System.Console.WriteLine($"You chose {playerChoice}");
      //     System.Console.WriteLine("You " + (Result)((2 + playerChoice - computerChoice) % 3));
      //   }

    }
  }
}
