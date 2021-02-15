using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._4_V._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int x0 = 1;
            int x1 = 7, x2 = 7, x3 = 7;
            double xn=0;
            for (int i = 1; i <= n; i++)
            {
                xn = (x3 * (1 + x2) + x1) / x0;
                x3 = (int)xn;
                x2 = x3;
                x1 = x2;
                x0 = x1;
            }
            Console.WriteLine("xn= " + xn);
        }
    }
}
