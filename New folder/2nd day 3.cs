using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            myclass c1 = new myclass();
            c1.print();
            Console.ReadKey();

        }
    }


    class myclass
    {
        public void print()
        {
            Console.WriteLine("hello class");

        }


    }
}
