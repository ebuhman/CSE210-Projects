public class WritingAssignment : Assignment
{
    // Attributes
    private string _title;

    // Behaviors

    // Setters
    public WritingAssignment()
    {
        _title = "Generic Title";
    }
    public WritingAssignment(string _studentName, string _topic, string title) : base(_studentName, _topic)
    {
        _title = title;
    }
    // Getters
    public string GetWritingInformation()
    {
        return _title;
    }
}