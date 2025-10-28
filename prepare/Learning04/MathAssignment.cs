public class MathAssignment : Assignment
{
    // Attributes
    private string _textbookSection;
    private string _problems;

    // Behaviors

    // Setters
    public MathAssignment()
    {
        _textbookSection = "Section 1.0";
        _problems = "Problems 1-2";
    }
    public MathAssignment(string _studentName, string _topic, string section, string problems) : base(_studentName, _topic)
    {
        _textbookSection = section;
        _problems = problems;
    }
    // Getters
    public string GetHomeworkList()
    {
        return _textbookSection + " " + _problems;
    }
}