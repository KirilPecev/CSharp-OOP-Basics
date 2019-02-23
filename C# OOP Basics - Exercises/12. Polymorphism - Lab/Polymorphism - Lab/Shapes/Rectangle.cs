using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.Height), "Height cannot be zero or negative!");
                }
                height = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.Width), "Width cannot be zero or negative!");
                }
                width = value;
            }
        }

        public override double CalculateArea()
        {
            return this.height * this.width;
        }

        public override double CalculatePerimeter()
        {
            return (this.height + this.width) * 2;
        }

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
