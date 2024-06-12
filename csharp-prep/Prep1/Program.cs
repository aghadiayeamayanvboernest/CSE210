using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their name. 
        Console.WriteLine();
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        // this line of code capitalize the first letter of the user input
        string capitalizedFirstName = firstname.Substring(0, 1).ToUpper() + firstname.Substring(1).ToLower();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
        // this line of code capitalize the first letter of the user input
        string capitalizedlastname = lastname.Substring(0,1).ToUpper() + lastname.Substring(1).ToLower();
        
        Console.WriteLine();
        Console.WriteLine($"Your name is {capitalizedlastname}, {capitalizedFirstName} {capitalizedlastname}");
        Console.WriteLine();
    
    }
}    