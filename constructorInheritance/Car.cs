using System;
using System.Collections.Generic;
using System.Text;

namespace constructorInheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) :base(registrationNumber)
        {
            Console.WriteLine("car is being initialized {0}", registrationNumber);
        }
    }
}
