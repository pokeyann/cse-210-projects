using System;
using System.Collections.Generic;

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

    int sum = 0;
    foreach (int number in numbers)
    {
      sum += number;
    }

    Console.WriteLine($"The sum is: {sum}");


  }
}