using System;

namespace upcasting
{
    //Base class
    class Shape
    {
        //Draw()available to base class Shape and all child classes
        public virtual void Draw()
        {
            Console.WriteLine("Shape");
        }
    }
    //derived class
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle ");
        }

        //Speciallized method available to only Circle class
        public void FillCircle()
        {
            Console.WriteLine("Filling a Circle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Use Base class reference
            Shape circle = new Circle();//Up-casting.
            circle.Draw();
            baseObj.Draw();
            Console.WriteLine("Hello World!");

            Circle derivedObj = (Circle)baseObj; //Down-casting-casting.
            derivedObj.Draw();
            derivedObj.FillCircle();
        }
    }
}
