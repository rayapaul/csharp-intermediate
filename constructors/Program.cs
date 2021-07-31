using System;

namespace constructors
{
    //parameterised constructor
    class Bike
    {
        public string models;
        public Bike(string modelName)
        {
            models =modelName ;
        }
    }
    class Car
    {//default constructor
        public string model;
        public Car()
        {
            model = "audi";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
            Bike honda = new Bike("activa");
            Console.WriteLine(honda.models);
        }
    }
}
