using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // Add a comment to this video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Get the number of comments on this video
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Get the title of the video
    public string GetTitle()
    {
        return _title;
    }

    // Get the author of the video
    public string GetAuthor()
    {
        return _author;
    }

    // Get the length of the video in seconds
    public int GetLength()
    {
        return _length;
    }

    // Get all comments for this video
    public List<Comment> GetComments()
    {
        return _comments;
    }
}
