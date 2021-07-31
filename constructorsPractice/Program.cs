using System;

namespace constructorsPractice
{
    public class Car
    {
        public string model;
        public Car(string modelName)
        {
            this.model = modelName;
        }
        class Program
        {

            static void Main(string[] args)
            {
                Car Audi = new Car("X123AB");
                Console.WriteLine("my car model is{0}",Audi.model);
                Console.WriteLine("Hello World!");
            }
        }
    }
}
