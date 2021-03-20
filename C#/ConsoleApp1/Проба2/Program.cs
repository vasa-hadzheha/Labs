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
            int x1 = 0;
            int y1 = 0;
            int x2 = 3;
            int y2 = 0;
            int x3 = 0;
            int y3 = 3;
            double a1 = x2 - x1;
            double a2 = y2 - y1;
            double b1 = x3 - x1;
            double b2 = y3 - y1;
            double ab = a1 * b1 + a2 * b2;
            Console.WriteLine(ab);
            double mod_a = Math.Sqrt(a1 * a1 + a2 * a2);
            Console.WriteLine(mod_a);
            double mod_b = Math.Sqrt(b1 * b1 + b2 * b2);
            Console.WriteLine(mod_b);
            double angle =((Math.Acos(ab / (mod_a * mod_b))) *180)/Math.PI;
            Console.WriteLine(angle);
        }
    }
}
