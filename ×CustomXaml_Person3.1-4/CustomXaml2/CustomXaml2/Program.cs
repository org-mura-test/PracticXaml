// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace CustomXaml2
{
    using System;

    public class Person
    {
        public Person()
        {
            this.Birthday = DateTime.Now;
        }

        public DateTime Birthday { get; private set; }
    }
}