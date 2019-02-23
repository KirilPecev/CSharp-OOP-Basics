using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleInter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectangle> rectangles = new List<Rectangle>();
            int[] information = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numOfRectangles = information[0];
            int intersectionChecks = information[1];

            for (int i = 0; i < numOfRectangles; i++)
            {
                string[] rectangleInfo = Console.ReadLine().Split();
                string id = rectangleInfo[0];
                double width = double.Parse(rectangleInfo[1]);
                double height = double.Parse(rectangleInfo[2]);
                double horizontal = double.Parse(rectangleInfo[3]);
                double vertical = double.Parse(rectangleInfo[4]);

                rectangles.Add(new Rectangle(id, width, height, horizontal, vertical));
            }

            for (int i = 0; i < intersectionChecks; i++)
            {
                string[] rectanglesID = Console.ReadLine().Split();
                Rectangle firstRectID = rectangles.Where(r => r.ID == rectanglesID[0]).FirstOrDefault();
                Rectangle secondRectID = rectangles.Where(r => r.ID == rectanglesID[1]).FirstOrDefault(); ;
                Console.WriteLine(firstRectID.CheckForIntersection(secondRectID) ? "true" : "false");
            }
        }
    }
}
