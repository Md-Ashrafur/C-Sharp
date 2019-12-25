using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            class Program
{
  
    
        Console.WriteLine("Type an integer:");
        string line = Console.ReadLine(); // Read string from console
        int value;
        if (int.TryParse(line, out value)) // Try to parse the string as an integer
        {
            Console.Write("Multiply integer by 10: ");
            Console.WriteLine(value * 10); // Multiply the integer and display it
        }
        else
        {
            Console.WriteLine("Not an integer!");
        }
    
}

        }
    }
}
