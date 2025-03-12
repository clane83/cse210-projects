using System;




class Video
{
    public string _author;
    public string _title;
    public string _length;
    private List<Comment> _comments = new List<Comment>(); // Stores comments

    public void AddComments(string commenter, string text)
    {
        _comments.Add(new Comment(commenter, text));
    }

    public int GetCommentCount()
    {
        return _comments.Count();
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_length} seconds");
        Console.WriteLine($"Number of Comments:{GetCommentCount()}");
        Console.WriteLine($"Comments:");

        foreach (var comment in _comments)
        {
            Console.WriteLine($" - Commenter:{comment._commentor}:\"{comment._comment}\"");
        }
    }
}