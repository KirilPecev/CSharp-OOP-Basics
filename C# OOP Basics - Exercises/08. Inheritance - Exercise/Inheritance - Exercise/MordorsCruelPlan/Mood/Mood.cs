using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Mood
{
    class Mood
    {
        public string MoodName { get; private set; }

        public Mood(string mood)
        {
            this.MoodName = mood;
        }
    }
}
