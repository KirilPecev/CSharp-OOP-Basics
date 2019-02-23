using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari.Interfaces
{
    public interface ICarable
    {
        string Model { get; set; }
        string Driver { get; set; }

        string Brakes();
        string gasPedal();

    }
}
