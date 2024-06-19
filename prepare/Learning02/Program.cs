using System;

// Main Program class
class Program
{
    //Main Method, entry point of the program
    static void Main(string[] args)
    {   
        //Create the first job instance
        Job job1 = new Job();
        job1._jobTitle ="User experience (UX) designer";
        job1._companyName = "Apple";
        job1._startYear = 2010;
        job1._endYear = 2017;

        // Create the second job instance 
        Job job2 = new Job();
        job2. _jobTitle = "Web Developer";
        job2._companyName = "Amazon";
        job2._startYear = 2017;
        job2._endYear = 2023;

        // create a new resume instance 
        Resume userResume = new Resume();
        userResume._userName ="Aghadiaye Amayanvbo Ernest";

        //Add the job to the resume
        userResume._jobs.Add(job1);
        userResume._jobs.Add(job2);

        //Display th resume details
        userResume.Display();
    }
        
}