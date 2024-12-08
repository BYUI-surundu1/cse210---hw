// Derived class for Math assignments
public class MathAssignment : Assignment
{
// Private member variables specific to Math assignments
    private string _section;
    private string _problems;

// Constructor that calls the base class constructor and initializes Math-specific variables
    public MathAssignment(string studentName, string topic, string section, string problems)
        : base(studentName, topic)  // Call the base class constructor to set studentName and topic
    {
        _section = section;
        _problems = problems;
    }

// Method to display the homework list
    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}
