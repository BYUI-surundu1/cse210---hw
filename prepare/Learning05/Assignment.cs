// Assignment.cs is the base class
public class Assignment
{
    // Private member variables
    private string _studentName;
    private string _topic;

    // Constructor to initialize the properties
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to return the summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Getter for studentName (if needed for derived classes)
    public string GetStudentName()
    {
        return _studentName;
    }
}
