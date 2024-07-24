using System;
using System.Reflection.PortableExecutable;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        // Creating a list to store the videos 
        List<Video> videos = new List<Video>();

        // this set is where i create 3 videos with appropriate values 
        Video video1 = new Video("Learn C# in One Hour", "Programming Guru(Ernesto)", 3600);
        Video video2 = new Video("Cooking pasta 101", "Chef Master Ernesto", 1800);
        Video video3 = new Video("Travel vlog: Paris", "GlobeTrotter", 2400);

        //code that Add the videos to the list 
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3); 

        // code that add 3 comments to video
        video1.AddComment(new Comment("Alice","Great tutorial!"));
        video1.AddComment(new Comment("Bob Ryan", "Very Informative."));
        video1.AddComment(new Comment("Charlie Nehis", "Helped me a lot, thanks!"));

        video2.AddComment(new Comment("David Bee", "Yummy recipe!"));
        video2.AddComment(new Comment("Eve Nosa", "Easy to follow Instructions."));
        video2.AddComment(new Comment("Frank Igew", "My pasta turned out great!"));

        video3.AddComment(new Comment("Grace", "Beautiful footage of paris. "));
        video3.AddComment(new Comment("Heidi", "I want to visit paris now!" ));
        video3.AddComment(new Comment("Ivan", "Amazing vlog!"));

        //Iterate Through the list of videos and display the deatails 
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title:{video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            // code that wold Display Each Comment for the video 
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._text}");
            }

            Console.WriteLine();
        }
    

    }
}