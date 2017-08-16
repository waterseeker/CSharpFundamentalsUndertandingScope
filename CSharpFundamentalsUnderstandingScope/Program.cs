using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentalsUnderstandingScope
{
    class Program
    {
        static void Main(string[] args)
        {
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                Console.WriteLine(i);
            }
            //you can't access i because it does not exist outside of its code block
            //Console.WriteLine(i); 

            Console.WriteLine("Outside of the for: " + j);

            Console.ReadLine();
        }
    }
}
