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
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            //you can't access i because it does not exist outside of its code block
            //Console.WriteLine(i); 
            Console.ReadLine();
        }
    }
}
