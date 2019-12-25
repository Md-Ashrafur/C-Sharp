using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value 1: ");
            string a = Console.ReadLine();
            Console.Write("Enter Value 2: ");
            string b = Console.ReadLine();
            int intval1 = Int32.Parse(a);
            int intval2 = Int32.Parse(b);
            int sum = intval1 + intval2;
            Console.WriteLine(sum);
            Console.Read();

            Console.Write("Enter value 1 and 2: ");
            int sum1 = Int32.Parse(Console.ReadLine())+Int32.Parse(Console.ReadLine());
            Console.Write(sum1);
            Console.Read();

        }
    }
}
