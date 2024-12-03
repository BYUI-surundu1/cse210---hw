using System;

public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor to initialize the comment with name and text
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    // To display the comment information
    public void Display()
    {
        Console.WriteLine($"{Name}: {Text}");
    }
}

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> Comments { get; set; }

    // Constructor to initialize the video with title, author, and length
    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    // Method to display the video information and all comments
    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        // Display all the comments
        foreach (var comment in Comments)
        {
            comment.Display();
        }

        Console.WriteLine(); // Add a blank line between videos
    }
}

public class Program
{
    public static void Main()
    {
        // Create videos
        Video video1 = new Video("Amazing Cooking Recipe", "Chef Ivan", 120);
        Video video2 = new Video("How to Build a Robot", "Oghu Tech", 300);
        Video video3 = new Video("Top 10 Nature Spots", "Explorer's Edge", 180);

        // Create comments for video1
        video1.AddComment(new Comment("Alice", "Great recipe, I will try it!"));
        video1.AddComment(new Comment("Bob", "I love this dish, so delicious!"));
        video1.AddComment(new Comment("Charlie", "Thanks for the tips, Chef John!"));

        // Create comments for video2
        video2.AddComment(new Comment("David", "This robot is amazing!"));
        video2.AddComment(new Comment("Eve", "Can you make a tutorial for beginners?"));
        video2.AddComment(new Comment("Frank", "Such an impressive build, I want to learn more!"));

        // Create comments for video3
        video3.AddComment(new Comment("Grace", "These locations are breathtaking!"));
        video3.AddComment(new Comment("Heidi", "I visited the Grand Canyon, it was incredible."));
        video3.AddComment(new Comment("Ivan", "Nature at its best!"));

        // List of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through the list of videos and display details
        foreach (var video in videos)
        {
            video.Display();
        }
    }
}

