using System;
using System.Collections.Generic;

class Video
{
    public string _title;
    public string _author;
    public int _seconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumComments()
    {
        return _comments.Count;
    }

    public string TheComment()
    {
        string result = "";
        foreach (Comment comment in _comments)
        {
            result += $"- {comment._name}: {comment._text}\n";
        }
        return result;
    }
}