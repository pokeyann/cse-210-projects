using System;
using System.IO;

class Journal
{ //METHODS

  // Write
  //  Create an Entry object
  //  Add object to the list

  // Display
  //  loop through the list
  //    call the entry.display()
  List<string> userInput = new List<string>();

  public void WriteEntry()
  {
    PromptGenerator q = new PromptGenerator();
    q.PromptQuestion();

    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();
    //Console.WriteLine(dateText);

    Console.Write("> ");

    string input = Console.ReadLine();

    userInput.Add(input);

    foreach (string w in userInput)
    {
      Console.WriteLine(w);
    }

    Console.WriteLine(userInput.Capacity);
  }

  public void Display()
  {
    Console.WriteLine("Test"); // does display
    //Journal item = new Journal();
    //item.WriteEntry();


    /*foreach (userInput in userEntryList);
    {
      Console.WriteLine();
    }*/

    //date
    //PromptQuestion
    //WriteEntry

    /*All journal entries are displayed
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

    For each userEntryList iterate through and display*/
  }
  public void SaveToFile() //(List<string> userEntryList)
  {
    Console.WriteLine("What is the filename? ");
    Console.ReadLine();

    string filename = "journal.txt";

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      //foreach (string userInput in input)
      outputFile.WriteLine($"{userInput}");
    }

    Console.WriteLine("test"); // did not work

    // SaveToFile();

  }
  public void LoadFromFile()
  {
    Console.WriteLine("what is the filename? ");
    Console.ReadLine();

    string filename = "journal.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
      string[] parts = line.Split(",");
    }

    return;
  }

  public void Quit()
  {
    Environment.Exit(0);

    return;
  }
}