using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings
    {
        private List<string> data = new List<string>();

        public void Push(string item)
        {
            data.Add(item);
        }

        public string Pop()
        {
            string result = string.Empty;
            if (!IsEmpty())
            {
                result = this.data[this.data.Count - 1];
                data.RemoveAt(this.data.Count - 1);
            }
            return result;
        }

        public string Peek()
        {
            string result = string.Empty;
            if (!IsEmpty())
            {
                result = this.data[this.data.Count - 1];
            }
            return result;
        }

        public bool IsEmpty()
        {
            return this.data.Count == 0;
        }
    }
}
