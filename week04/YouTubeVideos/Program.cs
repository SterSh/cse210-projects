using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to make bread", "Susan Baker", 714);
        Video video2 = new Video("How many is too many", "Fred Glut", 346);
        Video video3 = new Video("What to do when bored", "Ferry Boardman", 842);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        Comment comment1 = new Comment("Holly Plates", "Yum!");
        Comment comment2 = new Comment("Barb Trihurd", "My bread never comes out that well!");
        Comment comment3 = new Comment("Greg Fytman", "That is a lot of sugar!");

        Comment comment4 = new Comment("Eric Smalls", "I think that might be too many");
        Comment comment5 = new Comment("Travis Burns", "You need to add more");
        Comment comment6 = new Comment("Drew Wright", "That's just the right amount");

        Comment comment7 = new Comment("Nancy Gaymes", "I am never bored, I have Nintendo!");
        Comment comment8 = new Comment("Wade Crock", "That seems like it might be fun!");
        Comment comment9 = new Comment("Justin Camplaighn", "This video is boring...");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        Console.Clear();

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}