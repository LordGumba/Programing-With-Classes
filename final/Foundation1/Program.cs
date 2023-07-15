using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create Video objects and add comments
        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment("User 1", "Comment 1 for Video 1");
        video1.AddComment("User 2", "Comment 2 for Video 1");
        video1.AddComment("User 3", "Comment 3 for Video 1");
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.AddComment("User 1", "Comment 1 for Video 2");
        video2.AddComment("User 2", "Comment 2 for Video 2");
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Author 3", 150);
        video3.AddComment("User 1", "Comment 1 for Video 3");
        video3.AddComment("User 2", "Comment 2 for Video 3");
        video3.AddComment("User 3", "Comment 3 for Video 3");
        video3.AddComment("User 4", "Comment 4 for Video 3");
        videos.Add(video3);

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine("Commenter: " + comment.CommenterName);
                Console.WriteLine("Comment: " + comment.CommentText);
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------------------------");
        }
    }
}