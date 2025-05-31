using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("The Future of AI", "TechTalk", 420);
        video1.AddComment(new Comment("Alice", "Great insights on AI!"));
        video1.AddComment(new Comment("Bob", "Very informative."));
        video1.AddComment(new Comment("Charlie", "Loved the examples."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("How to Cook Pasta", "ChefJohn", 300);
        video2.AddComment(new Comment("Dave", "Yummy!"));
        video2.AddComment(new Comment("Eve", "Tried this and it worked perfectly."));
        video2.AddComment(new Comment("Frank", "Can you do lasagna next?"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Mountain Biking Adventure", "OutdoorLife", 600);
        video3.AddComment(new Comment("Gina", "Looks thrilling!"));
        video3.AddComment(new Comment("Hank", "Where is this trail located?"));
        video3.AddComment(new Comment("Ivy", "Awesome drone footage."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Guitar Tutorial: Basics", "MusicMan", 480);
        video4.AddComment(new Comment("Jack", "Finally learned my first chord!"));
        video4.AddComment(new Comment("Karen", "Please do a fingerpicking lesson."));
        video4.AddComment(new Comment("Liam", "Very helpful, thanks!"));
        videos.Add(video4);

        // Display each video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}
