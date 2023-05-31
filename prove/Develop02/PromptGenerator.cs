using System;

class PromptGenerator
{
  public void PromptQuestion() // how to return?? 
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
