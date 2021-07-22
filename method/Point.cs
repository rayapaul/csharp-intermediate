using System;
using System.Collections.Generic;
using System.Text;

namespace method
{
    class Point
    {
        public int X;
        public int Y;
        //constructor used to initialize the varibles
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        //move method is added with 2parameter
        public void Move(int x, int y)

        {
            //changing their values using 2 arguments
            this.X = x;
            this.Y = y;
        }
        //overloading the move method by different signature
        public void Move(Point newLocation)
        {
            this.X = newLocation.X;
            this.Y = newLocation.Y;
        }
    }
}
