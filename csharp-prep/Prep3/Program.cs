using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Prep3 World!");

    Console.WriteLine("What is the magic number? ");
    string magicNumber = Console.ReadLine();

    Console.WriteLine("What is your guess? ");
    string guess = Console.ReadLine();

    int a = int.Parse(magicNumber);
    int b = int.Parse(guess);

    if (a > b)
    {
      Console.WriteLine("Higher");
    }

    else if (a < b)
    {
      Console.WriteLine("Lower");
    }

    else
    {
      Console.WriteLine("You guessed it!");
    }

  }
}