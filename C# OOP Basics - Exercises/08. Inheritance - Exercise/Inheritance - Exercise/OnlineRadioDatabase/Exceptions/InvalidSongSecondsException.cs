using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    class InvalidSongSecondsException : InvalidSongLengthException
    {
        private const string Message = "Song seconds should be between 0 and 59.";

        public InvalidSongSecondsException() : base(Message)
        {

        }
    }
}
