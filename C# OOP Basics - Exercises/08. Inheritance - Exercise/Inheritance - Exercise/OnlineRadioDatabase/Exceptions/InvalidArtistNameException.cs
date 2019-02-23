using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    class InvalidArtistNameException : InvalidSongException
    {
        private const string Message = "Artist name should be between 3 and 20 symbols.";

        public InvalidArtistNameException() : base(Message)
        {

        }
    }
}
