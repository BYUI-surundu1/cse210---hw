using System;

public class Cycling : Activity
{
    private double speed; // in miles per hour

    public Cycling(DateTime date, double duration, double speed) : base(date, duration)
    {
        this.speed = speed;
    }

    // Calculate distance for Cycling (miles)
    public override double GetDistance()
    {
        return (speed * Duration) / 60; // distance = speed * time / 60
    }

    // Calculate speed for Cycling (miles per hour)
    public override double GetSpeed()
    {
        return speed;
    }

    // Calculate pace for Cycling (minutes per mile)
    public override double GetPace()
    {
        return 60 / speed; // pace = 60 / speed
    }
}
