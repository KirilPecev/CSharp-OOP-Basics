using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Telephony.Interfaces;

namespace Telephony.Smartphone
{
    class Smartphone : ICalling, IBrowsing
    {
        private string number;
        private string site;
        public string Number
        {
            get { return number; }
            set
            {
                if (Regex.IsMatch(value, "[^0-9]"))
                {
                    throw new ArgumentException("Invalid number!");
                }

                number = value;
            }
        }

        public string Site
        {
            get { return site; }
            set
            {
                if (Regex.IsMatch(value, "[0-9]+"))
                {
                    throw new ArgumentException("Invalid URL!");
                }
                site = value;
            }
        }

        public string Browsing()
        {
            return $"Browsing: {this.Site}!";
        }

        public string Calling()
        {
            return $"Calling... {this.Number}";
        }
    }
}
