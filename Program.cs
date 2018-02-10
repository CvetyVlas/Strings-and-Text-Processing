using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            Console.WriteLine("Hi, "+name +" "+lastName);
            Console.WriteLine("Hi, {0} {1}", name, lastName);
        }
    }
}
