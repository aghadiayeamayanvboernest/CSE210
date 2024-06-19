//Define the job class
public class Job 
{
    //member variables to hold job details
    public string _jobTitle;
    public string _companyName;
    public int _startYear;
    public int _endYear;

    // Method to display Job information
    public void Display()
    {
        // output the job dettails in the specified format
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear} -{_endYear}");
    }
}