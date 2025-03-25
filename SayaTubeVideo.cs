using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class sayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    public sayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public int PlayCount { get; internal set; }

    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }
    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID : {id}");
        Console.WriteLine($"Title : {title}");
        Console.WriteLine($"Play Count : {playCount}");
    }
}