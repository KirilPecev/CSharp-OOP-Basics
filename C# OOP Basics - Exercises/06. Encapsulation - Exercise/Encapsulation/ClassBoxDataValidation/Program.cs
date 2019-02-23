using System;

namespace ClassBoxDataValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
       
            try
            {
                double surfaceArea = Box.SurfaceArea(length, width, height);
                double lateralSurfaceArea = Box.LateralSurfaceArea(length, width, height);
                double volume = Box.Volume(length, width, height);
                Console.WriteLine($"Surface Area - {surfaceArea:f2}");
                Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
                Console.WriteLine($"Volume - {volume:f2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }                   
        }
    }
}
