﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Bob","Kunga");
            p.Throw();
            Console.ReadLine();
        }
    }
}
