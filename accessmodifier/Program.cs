﻿using System;

namespace accessmodifier
{
    class Car
    {
        public string model = "Mustang";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
            Console.WriteLine("Hello World!");
        }
    }
}
