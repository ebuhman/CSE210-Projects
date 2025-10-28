using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Ethan", "Math");
        Console.WriteLine(assignment.GetSummary());
        MathAssignment math = new MathAssignment("Ethan", "Math", "Section 7.3", "Problems 8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        WritingAssignment writing = new WritingAssignment("Ethan", "History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}