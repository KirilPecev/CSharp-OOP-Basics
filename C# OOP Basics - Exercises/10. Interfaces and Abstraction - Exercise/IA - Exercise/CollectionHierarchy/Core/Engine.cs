using CollectionHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy.Core
{
    public class Engine
    {
        public void Run()
        {
            List<MyList> myLists = new List<MyList>();
            List<string> input = Console.ReadLine().Split().ToList();
            int removeOperations = int.Parse(Console.ReadLine());
            List<string> result = new List<string>();

            AddCollection addCollection = new AddCollection();
            foreach (var item in input)
            {
                int index = addCollection.Add(item);
                result.Add(index.ToString());
            }
            Print(result);

            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            foreach (var item in input)
            {
                int index = addRemoveCollection.Add(item);
                result.Add(index.ToString());
            }
            Print(result);

            MyList myList = new MyList();
            foreach (var item in input)
            {
                int index = myList.Add(item);
                result.Add(index.ToString());
            }
            Print(result);

            for (int i = 0; i < removeOperations; i++)
            {
                string item = addRemoveCollection.Remove();
                result.Add(item);
            }
            Print(result);

            for (int i = 0; i < removeOperations; i++)
            {
                string item = myList.Remove();
                result.Add(item);
            }
            Print(result);
        }

        public void Print(List<string> result)
        {
            Console.WriteLine(string.Join(" ", result));
            result.Clear();
        }
    }
}
