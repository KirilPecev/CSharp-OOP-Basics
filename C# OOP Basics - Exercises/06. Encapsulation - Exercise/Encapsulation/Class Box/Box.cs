using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBox
{
    class Box
    {
        public static double SurfaceArea(double length, double width, double height)
        {
            return 2 * length * width + 2 * length * height + 2 * width * height;
        }

        public static double LateralSurfaceArea(double length, double width, double height)
        {
            return 2 * length * height + 2 * width * height;
        }

        public static double Volume(double length, double width, double height)
        {
            return length * width * height;
        }
    }
}
