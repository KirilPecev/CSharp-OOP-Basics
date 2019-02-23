using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleInter
{
    class Rectangle
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private double horizontal;

        public double Horizontal
        {
            get { return horizontal; }
            set { horizontal = value; }
        }

        private double vertical;

        public double Vertical
        {
            get { return vertical; }
            set { vertical = value; }
        }

        public Rectangle(string ID, double width, double height, double horizontal, double vertical)
        {
            this.ID = ID;
            this.Width =  Math.Abs(width);
            this.Height = Math.Abs(height);
            this.Horizontal = horizontal;
            this.Vertical = vertical;
        }

        public bool CheckForIntersection(Rectangle rectangle)
        {
            return rectangle.Horizontal + rectangle.Width >= this.Horizontal &&
               rectangle.Horizontal <= this.Horizontal + this.Width &&
               rectangle.Vertical >= this.Vertical - this.Height &&
               rectangle.Vertical - rectangle.Height <= this.Vertical;
        }
    }
}
