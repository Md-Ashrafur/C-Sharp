/* Programme Name: My first C sharp
 * Author name: Md. someone
 * Task: Learnig to print in c#
 * Date and time: 26th October, 2018: 8.30am  */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            //Console.Write("c# programming: Learn to Build");
            //Console.Read();
           // Console.Clear();
           // Console.WriteLine("I'm Ashraf the Great");
            //Console.Read();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.Clear();
            Console.WriteLine("I'm Ashraf the Great");

           // Console.Clear();
            //Console.Read();

            Console.Beep(2100, 100);
            ConsoleColor col = Console.ForegroundColor;
            Console.SetWindowSize(100, 10);

            Console.Write(col);
            Console.CursorSize = 100;

            Console.Read();

            int i=100;
            int j = i;

            Console.WriteLine(j);
            Console.ReadKey();

        }
    }
}
