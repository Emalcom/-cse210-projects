using System;
using System.ComponentModel.DataAnnotations;
class Video
{
    public string Title {get; set;}
    public string Author { get; set;}
    public int Length { get; set;}
    private List<Comment> Comments { get; set;}

    public Video ( string title, string author, int lenght)
    {
        Title = title;
        Author = author;
        Length = lenght;
        Comments = new List<Comment>();

    }
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
    public int GetCommentCount()
    {
        return Comments.Count;
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");

        }
        Console.WriteLine(new string ('-', 30));

    }
}