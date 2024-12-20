using System;

public class Swimming : Activity
{
    private int laps; // Number of laps

    public Swimming(DateTime date, double duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    // Calculate distance for Swimming (in miles)
    public override double GetDistance()
    {
        return (laps * 50) / 1000 * 0.62; // 50 meters per lap * number of laps in miles
    }

    // Calculate speed for Swimming (miles per hour)
    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60; // speed = distance / time * 60
    }

    // Calculate pace for Swimming (minutes per mile)
    public override double GetPace()
    {
        return Duration / GetDistance(); // pace = time / distance
    }
}
