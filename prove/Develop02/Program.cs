using System;

//DEBUGGER ISSUES AGAIN! ARGH!!!!!!  Was debugging different file, use File --> Open Recent --> pick correct file path
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Develop02 World!");

    Console.WriteLine("Welcome to the Journaling!");

    Console.WriteLine("Please choose one of the following: ");

    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");

    Console.Write("What would you like to do? ");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
      case 1: // Do not want it to write this when the user has picked. Want the correct method to run
        Console.WriteLine("1. Write");
        Journal j = new Journal();
        j.WriteEntry();
        break;

      case 2:
        Console.WriteLine("2. Display");

        break;

      case 3:
        Console.WriteLine("3. Load");
        break;

      case 4:
        Console.WriteLine("4. Save");
        break;

      case 5:
        Console.WriteLine("5. Quit");
        break;
    }

    Journal w = new Journal();
    w.WriteEntry();


    //Entry();
    //SaveToFile();
    //LoadFromFile();
    // Quit();
  }


}


