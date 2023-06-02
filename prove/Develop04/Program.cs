using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Develop04 World!");



  }
}

/* Program class = main menu; after activity completed returns to main menu
    _startMessage Standard Starting Message: welcome starting message that will be shown in each activity class
        (${activity name Breathing, Reflection, or Listing})  --name of activity, 
        _descriptionMessage (${breathingDescription, reflecctionDescription, listingDescription} ) --activity description, 
        How long would you like to do activity? user input seconds  --ask & set seconds
            Welcome to {& {name of activity}}
            This activity ($ {what activity will do})
            How long... user input seconds, animation
            Prepare to begin pause for seconds showing countdown animation
            End of activity Good Job with pause and countdown animation
            You did (${activity}) for (length of time)

    Menu
        Console.WriteLine("Menu Options:" )
        --switch
        1. Start Breathing activity
        2. Start Reflecting activity
        3. Start Listing activity
        4. Quit
        Console.WriteLine("Select choice from menu; ")
        Console.ReadLine();

        StartMessage
        {
            Console.WriteLine($"Welcome to the " {xyz} Activity. );
            Console.WriteLine($"This activity will help you " {activity description});
            Console.WriteLine("How long, in seconds, would you like your session? ") (store in _activitySeconds)
            Console.ReadLine();
            --spinner animation
            Console.WriteLine("Get Ready" );
            --spinner animation

        }
        _activitySeconds = userinput

        EndMessage
        {
            Console.WriteLine("Well done!");
            --spinner animation
            Console.WriteLine($"You have completed {_activitySeconds} of the {xyz} Activity.")
            --spinner animation
        }

        Returns to Menu

        _spinnerAnimation = spinnerAnimation
        _numberCountDownAnimation = numberCountDownAnimation


    
Breathing class
    Starting Message : 
        welcome, from program class
        this activity Breathing description, from Program class?
        how long from Program Class
    Prepare from program class  countdown animation spinner
    Prompt to 
        Breathe in countdown animation numbers
        Breath out countdown animation numbers
        Ends when reached number of secs user input from starting message
    Ending Message :
        Well done from program class pause countdown animation spinner
        conpleted (length of time) of the (Breathing Activity) countdown animation spinner
    Return to Program class menu

    Program.StartMessage --
         Console.WriteLine($"Welcome to the " {_breathingActivity} Activity. );
            Console.WriteLine($"This activity will help you" {_breathingDescription});
            Console.WriteLine("How long, in seconds, would you like your session? ") (store in _activitySeconds)
            Console.ReadLine();
            --spinner animation
            Console.WriteLine("Get Ready" );
            --spinner animation

        _breathingActivity = "Breathing"
        _breathingDescription = "relax by walking you through breathing in and out slowly.
        Clear your mind and focus on your breathing."

        BreathingActivityMethod

        _breatheIn = "Breath in... " spinner number countdown
        _breathOut = "Now breath out... " spinner number countdown

        Console.WriteLine($"{_breathIn} spinner");
        Console.WriteLine($"{_breathOut} spinner");
        --repeat for however many _activitySeconds user input

    Program.EndMessage
        EndMessage
        {
            Console.WriteLine("Well done!");
            --spinner animation
            Console.WriteLine($"You have completed {_activitySeconds} of the {_breathingActivity} Activity.")
            --spinner animation
        }

    Return to Program Menu

Reflection class
    Starting Message:
        Welcome, from program class
        this activity Reflection Activity, from Program Class?
        how long from Program Class
    Prepare from program class countdown animation spinner
    Consider the following...
        Prompt question random
            When you have in mind press enter
            ponder questions countdown animation numbers
                ponder list of questions maybe random, displayed with countdown animation spinner for each one
    Ending message: from Program class
    Return to menu from program class

    Program.StartMessage --
         Console.WriteLine($"Welcome to the " {_reflectingActivity} Activity. );
            Console.WriteLine($"This activity will help you " {_reflectimgDescription});
            Console.WriteLine("How long, in seconds, would you like your session? ") (store in _activitySeconds)
            Console.ReadLine();
            --spinner animation
            Console.WriteLine("Get Ready" );
            --spinner animation

            _activitySeconds = userinput

        _reflectingActivity = Reflecting;
        _reflectingDescription = ("reflect on times in your life when you have shown strengthand resilience.
        This will help ou recognize the power you have and how you can use it in other aspects of your life. ");

        ReflectingActivityMethod

        Console.WriteLine("Consider the following prompt: ");

        List of prompts
        Random

        Console.WriteLine("When you have something in mind, press enter to continue");

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");  --spinner number countdown animation

        List of questions
        Random
        --spinner animation

    Program.EndMessage
        {
            Console.WriteLine("Well done!");
            --spinner animation
            Console.WriteLine($"You have completed {_activitySeconds} of the {_reflectingActivity} Activity.")
            --spinner animation
        }

        Returns to Menu        

Listing class
    Starting Message:
        Welcome, from program class
            this activity Listing Activity, from Program Class?
            how long from Program Class
        Prepare from program class countdown animation spinner
    List as many from prompt
        random prompt given countdown animation numbers
        you may begin,  type until timer is up
        you listed xyz items
    Ending message: from program class
    return to menu in program class

      StartMessage
        {
            Console.WriteLine($"Welcome to the " {_listingActivity} Activity. );
            Console.WriteLine($"This activity will help you " {_listingDescription});
            Console.WriteLine("How long, in seconds, would you like your session? ") (store in _activitySeconds)
            Console.ReadLine();
            --spinner animation
            Console.WriteLine("Get Ready" );
            --spinner animation

        }
        _activitySeconds = userinput

        _listingActivity = Listing
        _listingDescription = "reflect on the good things in your life by having you list as many things as
        you can in a certain area. "

        Console.WriteLine("List as many responses you can to the following prompt: ");

        List of prompt questions
        Random

        Console.WriteLine("You may begin in: "); --spinner number countdown animation
        Console.ReadLine();

    EndMessage
        {
            Console.WriteLine("Well done!");
            --spinner animation
            Console.WriteLine($"You have completed {_activitySeconds} of the {_listingActivity} Activity.")
            --spinner animation
        }

        Returns to Menu

public void Quit()
    {
        Environment.Exit(0);

        return;
    }
    

