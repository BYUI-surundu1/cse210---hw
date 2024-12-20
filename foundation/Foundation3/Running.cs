using System;

public class Running : Activity
{
    private double distance; // in miles

    public Running(DateTime date, double duration, double distance) : base(date, duration)
    {
        this.distance = distance;
    }

    // Calculate distance for Running
    public override double GetDistance()
    {
        return distance; // already in miles
    }

    // Calculate speed for Running (miles per hour)
    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60; // speed = distance / time * 60
    }

    // Calculate pace for Running (minutes per mile)
    public override double GetPace()
    {
        return Duration / GetDistance(); // pace = time / distance
    }
}
