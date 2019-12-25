using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int.Parse("abc");
            }

            catch (Exception ex)
            {
                Console.Write("abc");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
