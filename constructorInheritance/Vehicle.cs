using System;
using System.Collections.Generic;
using System.Text;

namespace constructorInheritance
{
    public class Vehicle
    {
        private string _registrationNumber;
        //default constructor
        //public Vehicle()
        //{
            //Console.WriteLine("vehicle is being initialized");
        //}
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("vehicle is being initialized{0}",registrationNumber);
        }
    }
}
