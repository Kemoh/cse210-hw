public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // The MathAssignment has four parameters of which it inherits two from the base class
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
    : base (studentName, topic)
    {
        // Here we set the MathAssignment specific variables
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

}