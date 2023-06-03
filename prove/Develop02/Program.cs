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

/*
Welcome statement

Program Class - Menu; after each choice complete return to this menu
  _choiceSelection do as switch, when choice is made program goes to correct class and/or method
  _askChoice ask use what they would like to do, get user input of _choiceSelection

Program Journal
  Write
   _writeEntry (_choiceSelection #1)
    _writeEntryPrompt, user given a random prompt
      random
    _writtenEntryFromUser, the user writes entry, give a > symbol to display to user where input will go.
  when press enter, returns to Program Class Menu

  Display
    All journal entries are displayed
    Date is diplayed for each _writeEntry
    _writeEntryPrompt is displayed for each _writeEntry
    _writtenEntryFromUser is displayed for each _writeEntry
    will iterate through and show all _writeEntry

      eg: 
      Date: 12/9/2023 - Prompt: If I had one thing I could do over today, what would it be?
      Speak more kindly to my children.
    
      Date: 12/9/2023 - Prompt: What was the best part of my day?
      Seeing the sun shine.
    When press enter, return to Program Class Menu

  Save
    Ask user for the filename
    User input filename, eg journal.txt
    When press enter, return to Program Class Menu

  Load
    Ask user for the filename
    User input filename, eg journal.txt that was used during Save.
    When press enter, return to Program Class Menu
    User then choose Display
    All _writeEntry are displayed per Display 
    When press enter, return to Program Class Menu
    Then repeat any choices, eg Write, Write is then added to _writeEntry, can Save again and file is replaced with
      updated information now including the new _writeEntry
    
  Quit
    When done can choose quit.

  Class Journal
  {
    string filname = "journal.txt";

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      outputFile.WriteLine(${_writtenEntryFromUser});
    }    

    string = _writtenEntryFromUser
    static void Write()
    {
      PromptGenerator q = new PromptGenerator();
      q.PromptQuestion();

      Journal newEntry = new Journal();
      Console.WriteLine(">" newEntry._writtenEntryFromUser);

      How does the date get saved to each entry, should date be added here, Display, or Save?
    }    

    static void Display()
    {

    }

  Class PromptGenerator
  {
    static void PromptQuestion()
    {
      List<string> prompt = new List<string>();
      prompt.Add("Which is better Marvel or DC, and why? ");
      prompt.Add("Where is your favorite placed you've traveled to? ");
      prompt.Add("What is your best advice? ");
      prompt.Add("What is your happiest memory? ");
      prompt.Add("What is one thing you would change, explain why? ");

      Random p = new Random();

      int randomPrompt = p.Next(prompt.Count);

      Console.WriteLine(prompt.ElementAt(randomPrompt));

      return;
    }
  }
  }



  



  

*/


