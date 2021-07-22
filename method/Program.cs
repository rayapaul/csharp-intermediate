using System;

namespace method
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var point = new Point(10, 20);
            
            point.Move(new Point(30, 60));
            Console.WriteLine("point is at:{0} ,{1}", point.X, point.Y);
            point.Move(100, 200);
            Console.WriteLine("point at:{0} ,{1}",point.X, point.Y);
        }
    }
}
