using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    public class MyList : IMyList
    {
        protected List<string> myList;
        public int Used
        {
            get
            {
                return myList.Count;
            }
        }

        public MyList()
        {
            this.myList = new List<string>();
        }

        public virtual string Remove()
        {
            string item = myList[0];
            this.myList.RemoveAt(0);
            return item;
        }

        public virtual int Add(string item)
        {
            this.myList.Insert(0, item);
            return 0;
        }
    }
}
