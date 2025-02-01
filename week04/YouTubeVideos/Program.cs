using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basics", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "this really helped me."));
        video1.AddComment(new Comment("Charlie", "Thanks for this video!"));

        Video video2 = new Video("OOP in C#", "Jane Smith", 850);
        video2.AddComment(new Comment("Dave", "Awesome content!"));
        video2.AddComment(new Comment("Eva","I finally understand OOP."));
        video2.AddComment(new Comment("Frank", "Can you make a video on design patterns?"));

        Video video3 = new Video("C# LINQ Tutorial", "Mark Johnson", 720);
        video3.AddComment(new Comment("Grace", "Very informative."));
        video3.AddComment(new Comment("Hellen", "Love how you explain thinbgs."));
        video3.AddComment(new Comment("Ian", "great video! Keep it up."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }


    }
}