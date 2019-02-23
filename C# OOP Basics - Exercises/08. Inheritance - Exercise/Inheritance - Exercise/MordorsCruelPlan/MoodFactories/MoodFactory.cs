using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan
{
    static class MoodFactory
    {
        public static Mood.Mood GenerateMood(int happiness)
        {
            if (happiness < -5)
            {
                return new Mood.Mood("Angry");
            }
            else if (happiness <= 0)
            {
                return new Mood.Mood("Sad");
            }
            else if (happiness <= 15)
            {
                return new Mood.Mood("Happy");
            }
            else
            {
                return new Mood.Mood("JavaScript");
            }
        }
    }
}
