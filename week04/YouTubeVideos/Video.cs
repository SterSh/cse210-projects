class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void Display()
    {
        int numComments = CountComments();

        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author} ");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {numComments}");
        Console.WriteLine("Comments:");
        DisplayComments();
        Console.WriteLine();
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count;
    }


}