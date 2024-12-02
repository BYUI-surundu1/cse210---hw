using System;
using System.Collections.Generic;

public class comment
{
    public string namespace _name
    {
        
    }
    public string _text
    {

    }
    public comment(string _name, string _text)
    {
        _name = Name;
        _text = Text;
    }
}
public class video
{
    public string _title
    {

    }
    public string _author
    {

    }
    public int _length
    {

    }
    public List<Comment> comments
    {

    }
    public Video(string _title, string _author, int length)
    {
        _title = Title;
        _author = Author;
        _length = Length;
        _comments = new List<comment>();
    }
    public void AddComment(comment comment)
    {
        comments.Add(_comment);
    }
    public int GetCommentCount()
    {
        return comment.Count;
    }
}

class Program
{
    static void Main(string)
    {
// creates videos
        Video video1 = new Video("Video 1 ", "Author 1", 300);
        Video video1 = new Video("Video 2 ", "Author 2", 240);
        Video video1 = new Video("Video 3 ", "Author 3", 180);
// creates comments
        Comment comment1 = new Comment("Frank Smith", "This is a great video!");
        Comment comment2 = new Comment("Francis Surundu", "I love this video!");
        Comment comment3 = new Comment("Maxwell Brian", "This video is okay!");
// add videos to comments
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video2.AddComment(comment3);
        video3.AddComment(comment1);
// creates list of videos
        List<videos> videos = new List<video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

// displays video information
        foreach (Video video in videos)
        {
            Console. WriteLine($"Title:{video.Title}");
            Console. WriteLine($"Author:{video.Author}");
            Console. WriteLine($"Length:{video.Length} seconds");
            Console.WriteLine($"Comment Count:{video.GetCommentCount()}");
// display comments
            foreach (comment1 in video.Comments)
            {
                Conole.WriteLine($"Comment by {comment.Name}:{comment.Text}");
            }

            Console.WriteLine();
        }


    }

}