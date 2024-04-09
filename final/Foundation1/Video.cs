using System.ComponentModel.DataAnnotations;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int NumOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"\"{_title}\"");
        Console.WriteLine($"-- by {_author} --");
        Console.WriteLine($"({_length} seconds - {NumOfComments()} comments)");
        Console.WriteLine();
    }

    public void DisplayAllComments()
    { 
        Console.WriteLine("Comments:");
        foreach (Comment c in _comments)
        {
            Console.WriteLine($"- {c.GetName()} -");
            Console.WriteLine($"\"{c.GetComment()}\"");
            Console.WriteLine();
        }
        Console.WriteLine("~~~~~~~~~~~~~~~");
    }
}