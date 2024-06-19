using System;

//define the reume class
public class Resume
{
    //member variable to hold the user's name
    public string _userName;

    //member variable to hold a list of job
    public List<Job> _jobs = new List<Job>();

    //Method to display resume information
    public void Display()
    {
        //output the user name
        Console.WriteLine($"Name: {_userName}");
        //out put the header for the jobs section 
        Console.WriteLine($"Jobs: ");

        // Loop through each job in the ist and Display ots datails
        foreach (Job job in _jobs)
        {
            // call the Display method of he job class
            job.Display();
        }
    }
}