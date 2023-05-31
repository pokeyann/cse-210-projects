using System;

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