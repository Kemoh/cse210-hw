// Video Class
class Video
{
    // Declare the member variables
    public string _title;
    public string _author;
    public int _length;  // Length in seconds
    public List<Comment> Comments;

    // Constructor to initialize the video with title, author, and length
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        Comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to return the number of comments
    public int NumberOfComments()
    {
        return Comments.Count;
    }
    
    // Method to display video information
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Video Title: {_title}, Author: {_author}, Length: {_length} seconds");
    }

    // Method to display all comments
    public void DisplayAllComments()
    {
        foreach (var comment in Comments)
        {
            comment.DisplayCommentInfo();
        }
    }
}


