using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Interfaces
{
    public interface IBuyer
    {
        string Name { get; set; }
        int Food { get; set; }

        void BuyFood();
    }
}
