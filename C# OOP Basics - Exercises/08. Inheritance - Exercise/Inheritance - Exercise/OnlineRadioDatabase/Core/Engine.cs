using OnlineRadioDatabase;
using System;
using System.Collections.Generic;


class Engine
{
    public void Run()
    {
        int n = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(";");
            try
            {
                if (input.Length != 3)
                {
                    throw new InvalidSongException();
                }

                string artist = input[0];
                string songName = input[1];
                string[] length = input[2].Split(":");

                int minutes = int.Parse(length[0]);
                int seconds = int.Parse(length[1]);

                songs.Add(new Song(artist, songName, minutes, seconds));
                Console.WriteLine("Song added.");
            }
            catch (InvalidSongException ise)
            {
                Console.WriteLine(ise.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid song length.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine($"Songs added: {songs.Count}");

        int totalLengthInSeconds = 0;
        foreach (var song in songs)
        {
            totalLengthInSeconds += song.GetLengthInSeconds();
        }

        int secondsToMinutes = totalLengthInSeconds / 60;
        int secondsResult = totalLengthInSeconds % 60;
        int minutesToHours = secondsToMinutes / 60;
        int minutesResult = secondsToMinutes % 60;
        int hoursResult = minutesToHours;

        Console.WriteLine($"Playlist length: {hoursResult}h {minutesResult}m {secondsResult}s");
    }
}

