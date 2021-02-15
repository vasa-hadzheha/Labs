using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._2_Варіант_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            int c = Convert.ToInt32(Console.ReadLine());
            double k= Math.Min(a, b) + Math.Pow(Math.Max(b,c),2);
            Console.WriteLine("k={0}",k);

        }
    }
}
