using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Prep3 World!");

    //Console.Write("What is the magic number? ");
    //int magicNumber = int.Parse(Console.ReadLine());

    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 11);

    int guess = -1;    // needed to iterate through while loop, was not part of the random generator as originally thought. 

    while (guess != magicNumber)
    {
      Console.Write("What is your guess? ");    // Needed to be in the while loop for game continuation. 
      guess = int.Parse(Console.ReadLine());

      if (guess < magicNumber)
      {
        Console.WriteLine("Higher");
      }

      else if (guess > magicNumber)
      {
        Console.WriteLine("Lower");
      }

      else
      {
        Console.WriteLine("You guessed it!");
      }
    }
  }
}
