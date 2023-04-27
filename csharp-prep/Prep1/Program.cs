using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("What is your first name? ");
    string fname = Console.ReadLine();


    Console.Write("What is your last name? ");
    string lname = Console.ReadLine();


    Console.WriteLine($"Your name is {lname}, {fname} {lname}.");

    /*Console.Write("What is your first name? ");
    string first = Console.ReadLine();

    Console.Write("What is your last name? ");
    string last = Console.ReadLine();

    Console.WriteLine($"Your name is {last}, {first} {last}.");*/

  }
}



