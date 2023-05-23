using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Learning02 World!");


    Job job1 = new Job();
    job1._company = "Googly Eyes";
    job1._jobTitle = "Placement Prankster";
    job1._startYear = 1976;
    job1._endYear = 2020;

    Job job2 = new Job();
    job2._company = "House o' Crackers";
    job2._jobTitle = "Cracker Stacker Attacker";
    job2._startYear = 2050;
    job2._endYear = 2060;

    job1.DisplayJobDetails();
    job2.DisplayJobDetails();

    Resume resume1 = new Resume();
    resume1._name = "The Hulk";

    resume1._jobs.Add(job1);
    resume1._jobs.Add(job2);

    Console.WriteLine(resume1._jobs[0]._jobTitle);

    resume1.Display();


  }
}