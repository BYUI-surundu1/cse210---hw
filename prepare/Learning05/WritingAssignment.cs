// Derived class for Writing assignments
public class WritingAssignment : Assignment
{
    // Private member variable specific to Writing assignments
    private string _title;

    // Constructor that calls the base class constructor and initializes Writing-specific variables
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)  // Call the base class constructor to set studentName and topic
    {
        _title = title;
    }

    // Method to get the writing information (title and student name)
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}
