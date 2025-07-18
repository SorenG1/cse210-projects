using System;

public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Get the name of the person who made the comment
    public string GetName()
    {
        return _name;
    }

    // Get the text of the comment
    public string GetText()
    {
        return _text;
    }
}
