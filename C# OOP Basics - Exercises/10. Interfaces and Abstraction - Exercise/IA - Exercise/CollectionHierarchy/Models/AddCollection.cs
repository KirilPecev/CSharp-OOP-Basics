using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    class AddCollection : MyList, IAddCollection
    {
        public override int Add(string item)
        {
            base.myList.Add(item);
            return myList.Count - 1;
        }
    }
}
