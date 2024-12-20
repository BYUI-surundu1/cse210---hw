
using System;

class Program
{
    static void Main()
    {
        // Creating instances of each activity
        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),  // Running (30 min) with 3 miles
            new Cycling(new DateTime(2022, 11, 4), 45, 15.0), // Cycling (45 min) with 15 mph
            new Swimming(new DateTime(2022, 11, 5), 40, 30)   // Swimming (40 min) with 30 laps
        };

        // Iterating through the activities and displaying summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
