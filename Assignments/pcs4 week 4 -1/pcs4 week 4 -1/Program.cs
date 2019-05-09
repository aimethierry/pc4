using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcs4_week_4__1
{
    class Program
    {

        private static int Puzzle(int a, ref int b)
        {
            int c = a + b;
            a = 5;
            b = a * 3;
            return c;
        }
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            int c = Puzzle(a, ref b);
            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }



    }
}
