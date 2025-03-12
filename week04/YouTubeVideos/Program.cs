using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video{_author = "Tina", _title = "testing video", _length = "120"};

        video1.AddComments("Bailey", "This is a great video.  Thanks for sharing");
        video1.AddComments("Jamie", "Wonderful video");
        video1.AddComments("Victoria", "How did you do that?");

        videos.Add(video1);

        foreach (var video in videos)
        {
            video.Display();
        }
    }
}