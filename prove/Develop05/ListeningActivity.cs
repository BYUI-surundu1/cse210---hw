using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void PerformActivity()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        int startTime = Environment.TickCount;
        int count = 0;

        while ((Environment.TickCount - startTime) / 1000 < Duration)
        {
            Console.Write("List item: ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");
    }
}
