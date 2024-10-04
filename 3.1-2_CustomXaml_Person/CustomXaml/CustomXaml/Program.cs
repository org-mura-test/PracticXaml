using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace CustomXaml1
{
    public class Person
    {

        public DateTime Birthday { get; private set; }

        public Person()
        {
            this.Birthday = DateTime.Now;
        }

    }

}
