using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Comment comment1 = new Comment("B0b", "Great Video!");
        Comment comment2 = new Comment("Sally123", "Learned a lot, thx!");
        Comment comment3 = new Comment("JoeJoe", "Love this video");
        Comment comment4 = new Comment("CatMom", "Super helpful");
        Comment comment5 = new Comment("codingFanatic", "cool");
        Comment comment6 = new Comment("DogMom", "Pythons are scary");
        Comment comment7 = new Comment("ILikeTurtles", "You should teach turtles to sing next");
        Comment comment8 = new Comment("TimothySmith", "Very Interesting");
        Comment comment9 = new Comment("FBIAgent28", "Checks out.");
        Comment comment10 = new Comment("UrMom", "So cute!!!");
        Comment comment11 = new Comment("AnimalLover", "Do you need a degree to do that?");
        Comment comment12 = new Comment("TurtleDad", "My turtles and I would love that job!");
        Comment comment13 = new Comment("IceCreamMaker", "I like my job better.");

        Video video1 = new Video("C# 101", "C#oding Teacher", new TimeSpan(0, 0, 37, 42), [comment1, comment2, comment3]);
        videos.Add(video1);
        Video video2 = new Video("Python for Beginners - Start Here!", "LearnPython", new TimeSpan(0, 0, 14, 53), [comment4, comment5, comment6]);
        videos.Add(video2);
        Video video3 = new Video("I taught my dogs how to sing...", "House of Dogs", new TimeSpan(0, 0, 8, 36), [comment7, comment8, comment9, comment10]);
        videos.Add(video3);
        Video video4 = new Video("A Day in the Life of a Programmer (Vlog)", "John Frank", new TimeSpan(0, 0, 21, 59), [comment11, comment12, comment13]);
        videos.Add(video4);

        foreach (Video vid in videos)
        {
            vid.DisplayVideoInfo();
        }

    }
}