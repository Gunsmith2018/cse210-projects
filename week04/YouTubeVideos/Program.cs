using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Handles comments. To change to a different video just do Video video2 = new Video("Fill thiss out
        Video video1 = new Video("How to Demo", "Beta Bob", 120);
        video1.AddComment(new Comment("Beta Bob", "This Demo was intresting."));

        videos.Add(video1);

        // displays all videos 
        foreach (Video v in videos)
        {
            v.Display();
        }
        }
    
}