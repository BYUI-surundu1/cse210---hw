using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int guessNumber = randomGenerator.Next(1, 11);
    
        bool continueGuess = true;
        while (continueGuess)
        {
            Console.Write("What is your magic number? ");
            int guess = int.Parse(Console.ReadLine());

            while (guess != guessNumber)
            {
                if (guessNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                
                else if (guessNumber < guess)
                {
                    Console.WriteLine("Lower");

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
    
                }

            Console.WriteLine("You guessed it right!");
                 
            Console.Write("Do you want to continue? (yes/no) ");
            string response = Console.ReadLine();
            continueGuess = response == "yes";
        
            }

        }

    }
}