using System;
using System.IO;

class Journal
{


  //METHODS

  // Write
  //  Create an Entry object
  //  Add object to the list

  // Display
  //  loop through the list
  //    call the entry.display()

  // Save

  // Load

  // Quit

  public void WriteEntry()
  {
    PromptGenerator q = new PromptGenerator();
    q.PromptQuestion();

    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();

    string filename = "journal.txt";

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      outputFile.WriteLine();


      outputFile.WriteLine("> ");

      Console.ReadLine(); //How do I get user input saved to Entry List in Entry.cs
    }


    //entry.Add(WriteEntry); How to add each WriteEntry to Entry()? Where to put DateTime and how to save specific
    //PromptQuestion for each Write to entry List?
  }

  public void UserEntryList() // should DateTime and PromptQuestion be added to WriteEntry? I think that WriteEntry 
                              //needs to added to entry list each time.  
  {
    List<string> userEntryList = new List<string>();

    Journal j = new Journal(); //attempt to connect Journal.cs with Entry.cs, so then can add new entries to the list.
    j.WriteEntry();

    //userEntryList.Add(Journal.); //How do I add the WriteEntry from Journal to userEntry List?

    Console.WriteLine(userEntryList.Capacity);


    return;

  }

  public void Display()
  {

    /*foreach (string item in UserEntryList)
    {
      Console.WriteLine(UserEntryList);
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
  public void SaveToFile()
  {
    Console.WriteLine("What is the filename? ");
    Console.ReadLine();

    // Below is the bones of the code, but the details are wrong, once figure out entry and write entry fix.
    string filename = "journal.txt";

    /*using (StreamWriter outputFile = new StreamWriter(filename))
    {
      foreach ()
      {
        outputFile.WriteLine();
      }

      SaveToFile(); // where should this be?
    }*/

    return;
  }

  public void LoadFromFile()
  {
    Console.WriteLine("what is the filename? ");
    Console.ReadLine();

    return;
  }

  public void Quit()
  {
    Environment.Exit(0);

    return;
  }
}