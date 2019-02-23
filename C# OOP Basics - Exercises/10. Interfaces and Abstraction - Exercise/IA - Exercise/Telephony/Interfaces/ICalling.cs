using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Interfaces
{
    public interface ICalling
    {
        string Number { get; set; }
        string Calling();
    }
}
