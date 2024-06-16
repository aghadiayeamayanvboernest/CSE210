using System;

class Program
{
    static void Main(string[] args)
    {
        //this line of code ca and display the welcome message 
        DisplayWelcome();

        //This line of code promtot thr user for yheir name ans store it
        string userName = promptUserName();

        //This line of code prompt the user for their favourite nmber and store it
        int userNumber = promptUserNumber();

        //Calculate the square of the user's favorite number 
        int squaredNumber = squareNumber(userNumber);

        //Display the result with the user's name and the squared number
        DisplayResult(userName, squaredNumber);
    }

    //Function to display a welcome message 
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program! ");
    }
    
    //Function to prompt the user for their name 
    static string promptUserName()
    {
        Console.Write("Please Enter your Name: ");
        string name =Console.ReadLine();
        string capitalizename = name.Substring(0, 1).ToUpper()  + name.Substring(1).ToLower();
        return capitalizename;
    }

    //Function to prompt the user for their favorite number 
    static int promptUserNumber()
    {
        Console.Write("Please Enter your Favourite Number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Function to calculate the square of a number 
    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    //Function to display the result with the user's name and squared number
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name},the square of your number is {square}");
    }
}   
    