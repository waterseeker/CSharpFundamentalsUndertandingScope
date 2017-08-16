using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalsUnderstandingScope
{
    class Program
    {

        //all enclosed/child code blocks have access to class level variables
        private static string k = ""; 

        static void Main(string[] args)
        {
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //can't access the l variable outside of its code block
                //Console.WriteLine("l: " + l);
            }
            //you can't access i because it does not exist outside of its code block
            //Console.WriteLine(i); 

            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("k: " + k);

            Console.ReadLine();
        }
    }
}
