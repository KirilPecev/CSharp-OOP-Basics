using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy.Models
{
    class AddRemoveCollection : MyList, IAddRemoveCollection
    {
        public override string Remove()
        {
            string item = base.myList.Last();
            base.myList.RemoveAt(myList.Count - 1);
            return item;
        }
    }
}
