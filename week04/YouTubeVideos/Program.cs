using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("YouTube Video Tracker");
        Console.WriteLine();

        // Create a list to store all our videos
        List<Video> videos = new List<Video>();

        // Create first video
        Video video1 = new Video("How to Cook Pasta", "Chef Maria", 450);
        
        // Add comments to first video
        Comment comment1 = new Comment("FoodLover123", "Great recipe! I tried this and it was delicious.");
        Comment comment2 = new Comment("PastaFan", "Thanks for the tips, very helpful!");
        Comment comment3 = new Comment("CookingBeginner", "Perfect for someone just starting to cook.");
        
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        
        videos.Add(video1);

        // Create second video
        Video video2 = new Video("10 Minute Morning Workout", "FitnessGuru", 600);
        
        // Add comments to second video
        Comment comment4 = new Comment("HealthyLife", "This workout is perfect for busy mornings!");
        Comment comment5 = new Comment("FitnessFan", "I do this every day now. Love it!");
        Comment comment6 = new Comment("MorningPerson", "Great way to start the day with energy.");
        Comment comment7 = new Comment("BusyMom", "Finally found a workout I can fit into my schedule!");
        
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);
        
        videos.Add(video2);

        // Create third video
        Video video3 = new Video("Learn Guitar in 30 Days", "MusicTeacher", 1800);
        
        // Add comments to third video
        Comment comment8 = new Comment("GuitarStudent", "This is exactly what I needed to get started!");
        Comment comment9 = new Comment("MusicLover", "Clear instructions and easy to follow.");
        Comment comment10 = new Comment("Beginner", "Can't wait to try these exercises tomorrow.");
        
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);
        
        videos.Add(video3);

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength() + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine();
            Console.WriteLine("Comments:");
            
            List<Comment> comments = video.GetComments();
            foreach (Comment comment in comments)
            {
                Console.WriteLine(comment.GetName() + ": " + comment.GetText());
            }
            
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();
        }
        
        Console.WriteLine("Done!");
    }
}