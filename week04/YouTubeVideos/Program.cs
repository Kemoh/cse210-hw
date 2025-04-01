using System;

class Program
{
    static void Main(string[] args)
    {
        // Comment comment = new Comment("Kemoh", "Nice product.");
        // Console.WriteLine(comment.DisplayCommentInfo());

        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create new video objects and add them to the list
        Video video1 = new Video("Learning C#", "John Smith", 180);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very informative, thank you!"));

        Video video2 = new Video("Advanced C# Techniques", "Jane Doe", 240);
        video2.AddComment(new Comment("Charlie", "This was a bit hard to follow."));
        video2.AddComment(new Comment("David", "Excellent explanations!"));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);

        // Iterate through each video in the list
        foreach (var video in videos)
        {
            // Display the video information
            video.DisplayVideoInfo();
            // Display all comments for the video
            video.DisplayAllComments();
            Console.WriteLine();  // For better readability between videos

        }
    }
}