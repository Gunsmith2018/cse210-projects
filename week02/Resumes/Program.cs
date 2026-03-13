using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job(); // Starts a new version of Job.cs
        job1._jobTitle = "Software Engineer"; // job1 is taking inputs from here (Program.cs) and running it through Job.cs
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job(); // Starts a new version of Job.cs
        job2._jobTitle = "Software Engineer"; // job1 is taking inputs from here (Program.cs) and running it through Job.cs
        job2._company = "Microsoft";
        job2._startYear = 2019;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Aaron Smith";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

        

    }
}