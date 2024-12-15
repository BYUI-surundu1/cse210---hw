
using System;

class Program
{
    static void Main(string[] args)
    {
        List<MindfulnessActivity> activities = new List<MindfulnessActivity>
        {
            new BreathingActivity(),
            new ReflectionActivity(),
            new ListingActivity()
        };

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            for (int i = 0; i < activities.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {activities[i].Name}");
            }
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice > 0 && choice <= activities.Count)
            {
                activities[choice - 1].StartActivity();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
