using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    class Song
    {
        private string name;

        private string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }
                name = value;
            }
        }

        private string artist;

        private string Artist
        {
            get { return artist; }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }
                artist = value;
            }
        }

        private int minutes;

        private int Minutes
        {
            get { return minutes; }
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }
                minutes = value;
            }
        }

        private int seconds;

        private int Seconds
        {
            get { return seconds; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                seconds = value;
            }
        }

        public Song(string artist, string name, int minutes, int seconds)
        {
            this.Artist = artist;
            this.Name = name;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public int GetLengthInSeconds()
        {
            return this.Minutes * 60 + this.Seconds;
        }

    }
}
