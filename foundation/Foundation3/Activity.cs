using System;

public abstract class Activity
{
    private DateTime date;
    private double duration; // in minutes

    public Activity(DateTime date, double duration)
    {
        this.date = date;
        this.duration = duration;
    }

    // Properties to get the date and duration
    public DateTime Date => date;
    public double Duration => duration;

    // Abstract methods for specific calculations
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Summary Method
    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {this.GetType().Name} ({Duration} min) - Distance {GetDistance():0.0}, Speed {GetSpeed():0.0}, Pace {GetPace():0.0} min per unit";
    }
}
