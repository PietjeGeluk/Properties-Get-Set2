//info ...
using System;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Person x = new Person();
            x.Name = "Kees";
            Console.WriteLine(x.Name);
        }


        class Person
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
    }
}
