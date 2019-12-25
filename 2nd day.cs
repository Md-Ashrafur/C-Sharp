using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "Md. Ashraf";
            string lastname = "Rahman";
            string fullname = firstname + " " +lastname;
            //string fullname2 = string.Concat(firstname, " ", lastname);

            Console.WriteLine(string.Concat(firstname, " ", lastname));

            //new part

            char[] letters = { 'O', 'n', 'y' };
            string st = new string(letters);

            Console.WriteLine(st);

            //new part

            string name = "Ashraf";
            char[] charArr = name.ToCharArray();
            foreach (char a in charArr)
            {

                Console.WriteLine(" "+a);
            }

            //new part

            string[] star = {"How", "am", "I", "?" };
            string sentence = String.Join(" ", star);
            Console.WriteLine(sentence);

            //new part

            string value = "AsHrAf";
            string upper = value.ToUpper();
            string lower = value.ToLower();

            Console.WriteLine(upper +"  "+ lower);

            Console.WriteLine(value.Length);    //length of a string


            //nwe part

            int[] arr2 = new int[5] {0, 1, 2, 3, 4} //size fixed

            int[] arr3 = new int[] {0, 1, 2, 3, 4} //size free

            int[,] arrr4 = new int[2,2] {(5,2),(2,2)};
            int[,] arr5 = new int [,] {(5,1), (4,5)};

               

            //new part











            Console.ReadLine();
        }
    }
}
