using System;

namespace constructor
{
    
    class Program

    {
        static void Main(string[] args)
        {
            var customer = new Customer(1,"raya");//new instance or object of customer class
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine("Hello World!");
        }
    }
}
