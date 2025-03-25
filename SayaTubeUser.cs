using System;
using System.Collections.Generic;
using System.Diagnostics;

public class SayaTubeUser
{
    private int id;
    private string username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        Debug.Assert(username != null, "Username tidak boleh null");
        Debug.Assert(username.Length <= 100, "Username tidak boleh lebih dari 100 karakter");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        Debug.Assert(video != null, "Video yang ditambahkan tidak boleh null");
        Debug.Assert(video.GetPlayCount() <= int.MaxValue, "Play count video tidak boleh melebihi batas integer");

        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.GetPlayCount();
        }
        return total;
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine($"User: {username}");
        int count = 0;
        foreach (var video in uploadedVideos)
        {
            if (count >= 8) break; // Maksimum print 8 video
            Console.WriteLine($"Video {count + 1} Judul: {video}");
            count++;
        }
    }
}