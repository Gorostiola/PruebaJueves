using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Linq;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] nombres = {"Jesus", "Goros", "Enriquez"};

            foreach(string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            Console.ReadKey();
        }

    }
}
