using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    class InvalidSongMinutesException : InvalidSongLengthException
    {
        private const string Message = "Song minutes should be between 0 and 14.";

        public InvalidSongMinutesException() : base(Message)
        {

        }
    }
}
