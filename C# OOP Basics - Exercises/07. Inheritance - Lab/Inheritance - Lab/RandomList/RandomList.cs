using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        List<string> data = new List<string>();
        Random random = new Random();
        public string RandomString()
        {
            string result = string.Empty;
            if (this.Count > 0)
            {
                int index = random.Next(0, this.Count - 1);
                result = this[index];
                this.RemoveAt(index);
            }

            return result;
        }
    }
}
