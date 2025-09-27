using System.Globalization;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private TimeSpan _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, TimeSpan length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    private int NumberOfComments()
    {
        int totalComments = 0;
        for (int i = 0; i < _comments.Count; i++)
        {
            totalComments++;
        }
        return totalComments;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"\n\n    '{_title}' \n    -{_author} \n    Duration: {_length.ToString("g")} \n{NumberOfComments()} Comments: \n{string.Concat(Enumerable.Repeat('-', 20))}");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine($"\n{string.Concat(Enumerable.Repeat('-', 50))}");
    }
}