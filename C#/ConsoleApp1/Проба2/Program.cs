using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проба2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x0 = 0;
            int x2 = 9;
            int x1 = 9;
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int xn=0;
            for (int i = 3; i < n+1; i++)
            {
                xn = x2 + 4 * x0;
                x0 = x1;
                x1 = x2;
                x2 = xn;

            }
            Console.WriteLine(xn);
        }
    }
}
