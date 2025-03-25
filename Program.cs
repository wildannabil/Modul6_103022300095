using System;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Eliyakim");


        for (int i = 1; i <= 10; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film {i} oleh Eliyakim");
            video.IncreasePlayCount(100000); 
            user.AddVideo(video);
        }

        Console.WriteLine("\nDetail Semua Video:");
        user.PrintAllVideoPlayCount();
        Console.WriteLine($"\nTotal Play Count: {user.GetTotalVideoPlayCount()}");
    }
}