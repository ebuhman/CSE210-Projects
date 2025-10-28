public class Assignment
{
    // Attributes
    private string _studentName;
    private string _topic;

    // Behaviors
    
    // Setters
    public Assignment()
    {
        _studentName = "John Doe";
        _topic = "PE";
    }
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    // Getters
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}