using System;

namespace classes
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi, {0} my name is:{1}", to, Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Raya";
            person.Introduce("xyz");
    
            Console.WriteLine("Hello World!");
        }
    }
}
