using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=10, b=5,c;

            c=myMethod(a,b);
            Console.WriteLine(c);

            myRefMethod(ref a, ref b);
            Console.WriteLine(a);

            Console.ReadKey();
        }

       static public int myMethod(int a, int b)
        {

            int c;
            Console.WriteLine("Jog kori");
           c=a+b;
           return c;
        }


       static public int myRefMethod(ref a, ref b)
       {

           int c;
           Console.WriteLine("Jog kori");
           c = a + b;
           a=c;
           return c;
       }

    }
}
