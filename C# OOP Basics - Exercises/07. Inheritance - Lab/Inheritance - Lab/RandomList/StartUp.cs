using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("blq");
            list.Add("mlq");
            list.Add("vlq");
            list.Add("glq");
            string word = list.RandomString();
            ;
        }
    }
}
