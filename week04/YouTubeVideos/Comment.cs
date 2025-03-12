using System;

class  Comment
{
    public string _commentor {get; set;}
    public string _comment {get; set;}
    

    public Comment(string commenter, string text)
    {
        _commentor = commenter;
        _comment = text;
    }
    
}