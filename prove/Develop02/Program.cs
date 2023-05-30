using System;

//DEBUGGER ISSUES AGAIN! ARGH!!!!!!
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Develop02 World!");

    Console.WriteLine("Welcome to the Journaling!"); // works to this point 5-29-23
    Console.Write("> ");
    Console.ReadLine();

    Menu();
    WriteEntry(); // so is the return working now?
    PromptQuestion();
    Entry();
    SaveToFile();
    LoadFromFile();
    Quit();

  }
  static void Menu() // How does the user choose and then run correct method? Should use a do/while with switch?
  {
    Console.WriteLine("Please choose one of the following: ");

    List<string> menu = new List<string>();

    menu.Add("1. Write");
    menu.Add("2. Display");
    menu.Add("3. Load");
    menu.Add("4. Save");
    menu.Add("5. Quit");

    Console.Write("What would you like to do? ");
    string choice = Console.ReadLine();

    foreach (string choice in menu) // got confused while researching how to do this
    {

    }

    return;
  }

  static void PromptQuestion() // how to return?? 
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

  static void WriteEntry()
  {
    PromptQuestion();
    Console.Write("> ");
    Console.ReadLine();

    //entry.Add(WriteEntry); How to add each WriteEntry to Entry()? Where to put DateTime and how to save specific
    //PromptQuestion for each Write to entry List?
  }

  static void Entry() // should DateTime and PromptQuestion be added to WriteEntry? I think that WriteEntry 
  //needs to added to entry list each time.  
  {
    List<string> entry = new List<string>();
    // display date, PromptQuestion, WriteEntry
    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();
    WriteEntry();
    Console.WriteLine(entry.Capacity);

    return;

  }

  static void SaveToFile()
  {
    Console.WriteLine("What is the filename? ");
    Console.ReadLine();

    return;
  }

  static void LoadFromFile()
  {
    Console.WriteLine("what is the filename? ");
    Console.ReadLine();

    return;
  }

  static void Quit() // how to quit? 
  {
    Environment.Exit();

    return;
  }

}