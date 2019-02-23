using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxDataValidation
{
    static class Box
    {
        private static double length;

        public static double Lenght
        {
            get { return length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value;
            }
        }

        private static double width;

        public static double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }

        private static double height;

        public static double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }

        public static double SurfaceArea(double length, double width, double height)
        {
            Lenght = length;
            Width = width;
            Height = height;

            return 2 * length * width + 2 * length * height + 2 * width * height;
        }

        public static double LateralSurfaceArea(double length, double width, double height)
        {
            Lenght = length;
            Width = width;
            Height = height;

            return 2 * length * height + 2 * width * height;
        }

        public static double Volume(double length, double width, double height)
        {
            Lenght = length;
            Width = width;
            Height = height;

            return length * width * height;
        }
    }
}
