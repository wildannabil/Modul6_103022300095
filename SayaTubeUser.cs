using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SayaTubeUser
{
    private int id;
    private string username;
    private List<sayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        this.username = username;
        this.uploadedVideos = new List<sayaTubeVideo>();
    }

    public void AddVideo(sayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.PlayCount;
        }
        return total;
    }

    public void PrintAllVideoPlaycount() 
    {
        Console.WriteLine($"User : {username}");
        foreach (var video in uploadedVideos)
        {
            video.PrintVideoDetails();
        }
    }
}
