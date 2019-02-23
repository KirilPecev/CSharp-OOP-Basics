using System;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            for (int startCount = 1; startCount <= size; startCount++)
            {
                PrintRow(size, startCount);
            }

            for (int startCount = size - 1; startCount >= 1; startCount--)
            {
                PrintRow(size, startCount);
            }
        }

        private static void PrintRow(int figureSize, int startCount)
        {
            for (int i = 0; i < figureSize - startCount; i++)
                Console.Write(" ");
            for (int col = 1; col < startCount; col++)          
                Console.Write("* ");
            Console.WriteLine("*");
        }
    }
}
