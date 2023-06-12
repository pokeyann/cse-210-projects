using System.IO;

class Journal
{
  // List of entry objects

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

    Console.Write("> ");

    Console.ReadLine(); //How do I get user input saved to Entry List see line 36 in Entry.cs

    //entry.Add(WriteEntry); How to add each WriteEntry to Entry()? Where to put DateTime and how to save specific
    //PromptQuestion for each Write to entry List?
  }
  public void Display()
  {
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
    When press enter, return to Program Class Menu*/
  }
  public void SaveToFile()
  {
    Console.WriteLine("What is the filename? ");
    Console.ReadLine();

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