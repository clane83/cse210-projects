using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video{_author = "Tina", _title = "testing video", _length = "120"};

        video1.AddComments("Bailey", "This is a great video.  Thanks for sharing");
        video1.AddComments("Jamie", "Wonderful video");
        video1.AddComments("Victoria", "How did you do that?");

        Video video2 = new Video{_author = "Bailey", _title = "Makeup Tutorial", _length = "120"};

        video2.AddComments("Tina", "That looks adorable");
        video2.AddComments("Jamie", "Great job");
        video2.AddComments("Victoria", "OMG, love it");

        Video video3 = new Video{_author = "Bailey", _title = "Dance Tutoria", _length = "120"};

        video3.AddComments("Tina", "You are really good at dancing");
        video3.AddComments("Jamie", "The splits at the end, loved it");
        video3.AddComments("Victoria", "Wow");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.Display();
        }
    }
}