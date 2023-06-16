using System;

//DEBUGGER ISSUES AGAIN! ARGH!!!!!!  Was debugging different file, use File --> Open Recent --> pick correct file path
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Develop02 World!");

    Console.WriteLine("Welcome to the Journaling!");


    bool loopContinue = true;
    while (loopContinue)
    {
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
        case 1: //seems to be working 6-12-23
          Journal j = new Journal();
          j.WriteEntry();
          break;

        case 2: // works 6-15-23
          Journal d = new Journal();
          d.Display();
          break;

        case 3:
          Journal l = new Journal();
          l.LoadFromFile();
          break;

        case 4:
          Journal s = new Journal();
          s.SaveToFile();
          break;

        case 5: //works 6-12-23
          Journal q = new Journal();
          q.Quit();
          break;
      }
    }

  }


}

/*
Welcome statement

Program Class - Menu; after each choice complete return to this menu
  _choiceSelection do as switch, when choice is made program goes to correct class and/or method
  _askChoice ask user what they would like to do, get user input of _choiceSelection

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
      WriteLine(">" newEntry._writtenEntryFromUser);

      How does the date get saved to each entry, should date be added here, Display, or Save?
      How does the specific prompt question get saved to file?  maybe automatic with entry?
    }    

    static void Display()
    {

      string filename = "journal.txt";
      string[] lines = System.IO.File. ReadAllLines(journal.txt);

      foreach (string line in lines)
      {
        string[] parts = line.Split(";");

        DateTime dateText = parts[0];
        string _writeEntryPrompt = parts[1];
        string _writtenEntryFromUser = parts[2];
      }

      DateTime theCurrentTime = DateTime.Now;
      string dateText = theCurrentTime.ToShortDateString();


    }

    static void Save()
    {
      Console.WriteLine("What is the filename? ");
      Console.ReadLine();

      string fileName = @"C:\School\cse210spring\cse-210-projects\prove\Develop02\Entry.cs\journal.txt";

      File.WriteAllText(fileName, {_writtenEntryFromUser});
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


