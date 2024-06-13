using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the numbers entered by the user
        List<int> numbers = new List<int>();

        // Initialize userNumber to -1 (we will use this to control the loop)
        int userNumber = -1;

        // Variable to hold the sum of the numbers
        int sum = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop to get user input until they enter 0
        do
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // Add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);

        // Calculate the sum of all numbers in the list
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Print the sum of the numbers
        Console.WriteLine($"The sum of the numbers you entered is: {sum}");

        // Print the number of entries
        Console.WriteLine($"You entered {numbers.Count} numbers");

        // Calculate the average of the numbers
        double average = (double)sum / numbers.Count;

        // Print the average of the numbers
        Console.WriteLine($"The average is {average}");

        // Find the maximum number in the list
        int maxNumber = numbers[0];

        // Initialize the variable to find the smallest positive number
        int? minPositiveNumber = null;

        // Loop to find the maximum number in the list
        foreach(int number in numbers)
        {
            if(number > maxNumber)
            {
                maxNumber = number;
            }
        }

        // Print the largest number
        Console.WriteLine($"The largest number is: {maxNumber} ");

        // Loop to find the smallest positive number
        foreach (int number in numbers)
        {
            if (number > 0 && (minPositiveNumber == null || number < minPositiveNumber))
            {
                minPositiveNumber = number;
            }
        }

        // Print the smallest positive number if it exists
        if (minPositiveNumber != null)
        {
            Console.WriteLine($"The smallest positive number is: {minPositiveNumber}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in the list.");
        }

        // Sort the list of numbers
        numbers.Sort();

        // Print the sorted list of numbers
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number); 
        }    
    }
}
