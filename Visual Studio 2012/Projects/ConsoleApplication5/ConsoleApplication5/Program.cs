using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter Value 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            int d = a - b;

            Console.WriteLine(c);




            Console.ReadLine();

        }
    }
}
