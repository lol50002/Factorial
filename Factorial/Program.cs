using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 b;
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fib(1,b));
            Console.ReadKey();
        }


        public static int Fib(int result,int n)
        {
            if (n <= 1) return result;
            return Fib(result * n, n=n-1);
        }
    }
}
