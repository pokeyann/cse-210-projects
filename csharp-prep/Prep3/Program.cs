using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Prep3 World!");

    Console.Write("What is the magic number? ");
    int magicNumber = int.Parse(Console.ReadLine());

    Console.Write("What is your guess? ");
    int guess = int.Parse(Console.ReadLine());

    while (guess != magicNumber)
    {
      if (guess < magicNumber)
      {
        Console.WriteLine("Higher");
        break;
      }

      else if (guess > magicNumber)
      {
        Console.WriteLine("Lower");
        break;
      }

      else
      {
        Console.WriteLine("You guessed it!");
      }
    }
  }
}
