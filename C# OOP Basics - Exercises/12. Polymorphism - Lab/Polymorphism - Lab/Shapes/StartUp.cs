using System;
using System.Collections.Generic;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new List<Shape>();
            list.Add(new Rectangle(2.5, 3.6));
            list.Add(new Rectangle(2, 3));
            list.Add(new Rectangle(2.6, 1.6));
            list.Add(new Circle(1.6));
            list.Add(new Circle(2));

            foreach (var item in list)
            {
                Console.WriteLine(item.Draw());
            }
        }
    }
}
