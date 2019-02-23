using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Interfaces
{
    public interface IBrowsing
    {
        string Site { get; set; }

        string Browsing();
    }
}
