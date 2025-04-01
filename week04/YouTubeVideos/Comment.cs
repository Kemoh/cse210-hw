
// Comment Class
public class Comment
{
    // Member variables
    public string _name;
    public string _text;

    // Constructor to initialize the comment with 
    // name and text
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
    
       // Method to display comment Info
    public void DisplayCommentInfo()
    {
        Console.WriteLine($"{_name}: {_text}");
    }
}