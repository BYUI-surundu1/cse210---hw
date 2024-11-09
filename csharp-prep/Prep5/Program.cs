using System;

class Program
{
    static void Main(string[] args)
    {
        // i did not have this for my program.
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static void PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return userName;
    }
    static void PromptUserNumber()
    {
        console.write("Please enter your favorite number: ");
        int number = int.Parse (console.ReadLine());

        return userNumber;
    }
    static int SquareNumber (int number)
    {
        int SquareNumber = number * number;

        return square;
    }
    static void DisplayResult(string name, int number)
    {
        console.WriteLine($"{name}, the square of your number is {square}");

    }
}