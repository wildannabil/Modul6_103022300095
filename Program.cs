using System;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Wildan Nabil Ramdhany");
        sayaTubeVideo sayaTubeavaideo1 = new sayaTubeVideo("Review Film 1 oleh Wildan Nabil Ramdhany");
        sayaTubeVideo sayaTubeavaideo2 = new sayaTubeVideo("Review Film 2 oleh Wildan Nabil Ramdhany");

        sayaTubeavaideo1.IncreasePlayCount(100);
        sayaTubeavaideo2.IncreasePlayCount(200);

        user.AddVideo(sayaTubeavaideo1);
        user.AddVideo(sayaTubeavaideo2);

        user.PrintAllVideoPlaycount();
    }
}