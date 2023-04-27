using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Prep2 World!");

    Console.WriteLine("What is your grade percentage? ");
    string letterGrade = Console.ReadLine();


    int a = int.Parse(letterGrade);

    if (a >= 90)
    {
      Console.WriteLine("Your grade is an A.");
    }

    else if (a >= 80)
    {
      Console.WriteLine("Your grade is a B.");
    }

    else if (a >= 70)
    {
      Console.WriteLine("Your grade is a C.");
    }

    else if (a >= 60)
    {
      Console.WriteLine("Your grade is a D.");
    }

    else
    {
      Console.WriteLine("Your grade is an F.");
    }

    if (a >= 70)
    {
      Console.WriteLine("Congratulations you passed the course!");
    }

    else
    {
      Console.WriteLine("Please try again.");
    }

    /*  Core Requirement 3, having issues debugging so can't check above code.  Writing this code so that I can check both, 
    once I have the debugging issue fixed.
    
    Console.WriteLine("What is your grade percentage? ");
    string letterGrade = Console.ReadLine();
    int a = int.Parse(letterGrade);

    string letter = "";
    
    if (a >= 90)
    {
      letter = "A";
    }

    else if (a >= 80)
    {
     letter = "B";
    }

    else if (a >= 70)
    {
     letter = "C";
    }

    else if (a >= 60)
    {
      letter = "D";
    }

    else
    {
     letter = "F";
    }
    
    Console.WriteLine($"Your grade is {letter}.") */

  }
}