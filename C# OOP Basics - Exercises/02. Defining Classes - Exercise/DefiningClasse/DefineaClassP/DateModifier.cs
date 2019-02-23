using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        DateTime firstDate = new DateTime();
        DateTime secondDate = new DateTime();

        public string FirstDate { get; set; }
        public string SecondDate { get; set; }

        public void CalculateDifference(string firstDate, string secondDate)
        {
            this.firstDate = DateTime.Parse(firstDate);
            this.secondDate = DateTime.Parse(secondDate);

            var time = this.firstDate - this.secondDate;
            Console.WriteLine("{0:dd}",time);
        }
    }
}
