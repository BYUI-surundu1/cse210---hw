
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Created an empty list for storing the numbers and asking the user to enter numbers
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished: ");

        //emphasizing that the user continously enters the numbers until he or she enters 0
        int userNumber = -1;
        while(userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        //calculating the sum, max and average.
        int sum = 0;
        foreach (int userNumber in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

         int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}
