using System;

public abstract class Shape
{
    public string Color 
    {
        
    }

    public Shape(string color)
    {
        Color = color;
    }

    public abstract double GetArea();
}
