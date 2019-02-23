using System;
using System.Linq;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle rectangle = new Rectangle()
            {
                TopLeft = new Point(coordinates[0], coordinates[1]),
                BottomRight = new Point(coordinates[2], coordinates[3])
            };

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
                bool result = rectangle.Contains(new Point(coordinates[0], coordinates[1]));
                Console.WriteLine(result);
            }
        }
    }
}
