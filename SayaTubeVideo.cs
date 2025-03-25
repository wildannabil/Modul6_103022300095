﻿using System;
using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title != null, "Judul video tidak boleh null");
        Debug.Assert(title.Length <= 200, "Judul video tidak boleh lebih dari 200 karakter");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count > 0, "Penambahan play count harus lebih dari 0");
        Debug.Assert(count <= 25000000, "Penambahan play count maksimal 25.000.000");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas maksimum integer!");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Judul: {title}");
        Console.WriteLine($"Jumlah Play: {playCount}\n");
    }

    public int GetPlayCount()
    {
        return playCount;
    }
}