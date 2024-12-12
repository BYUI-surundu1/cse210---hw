using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a MathAssignment object and test it
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());      // Print: "Roberto Rodriguez - Fractions"
        Console.WriteLine(mathAssignment.GetHomeworkList()); // Print: "Section 7.3 Problems 8-19"

        // Create a WritingAssignment object and test it
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());      // Prints: "Mary Waters - European History"
        Console.WriteLine(writingAssignment.GetWritingInformation()); // Print: "The Causes of World War II by Mary Waters"
    }
}