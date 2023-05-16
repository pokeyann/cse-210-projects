using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Prep4 World!");

    Console.WriteLine("Please enter a list of numbers, type 0 when finished.");

    List<int> numbers = new List<int>();

    int userNumber = -1;

    while (userNumber != 0)
    {

      Console.Write("Enter number: ");

      string userResponse = Console.ReadLine();
      userNumber = int.Parse(userResponse);
    }

  }
}