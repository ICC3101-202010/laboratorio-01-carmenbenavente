using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_1
{
    public class Person
    {
        private string name;
        private string lastName;
        public Person(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
        public void Throw()
        {
            Random number = new Random();
            int play = number.Next(0, 3);
            Console.WriteLine(play);
        }

    }
}
