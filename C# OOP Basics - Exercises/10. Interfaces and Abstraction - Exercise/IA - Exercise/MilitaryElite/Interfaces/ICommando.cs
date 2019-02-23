using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        List<IMission> Missions { get; }
    }
}
