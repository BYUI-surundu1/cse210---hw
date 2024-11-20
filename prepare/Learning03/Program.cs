using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction = new Fraction(3/4);
        Console.WriteLine(myFraction.GetFractionString());
        Console.WriteLine(myFraction.GetValue());
        Console.WriteLine(myFraction.ToString());
    }

}