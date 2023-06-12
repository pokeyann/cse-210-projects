class Entry
{

  // ATTRIBUTES
  // PromptGenerator object
  // Date
  // Prompt
  // response

  // CONSTRUCTOR
  //    Set the date
  //    Get and set the prompt
  //    display prompt
  //    get and set response

  // CONSTRUCTOR 2 (date, prompt, response)
  //    set the attributes

  // METHODS

  // Display()
  //    display date, repsonse, prompt

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
}