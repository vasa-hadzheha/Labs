using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._1_Варіант_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            float x = float.Parse(Console.ReadLine());
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            double s = 0;
            //int i = 1;
            /*while (i <= n)
            {
                s += Math.Pow(Math.Sin(x), i);
                i++;
                Console.WriteLine(s);
            }*/
            for (int i = 1; i <= n; i++)
            {
                s += Math.Pow(Math.Sin(x), i);
                Console.WriteLine("s= " + s);
            }
            Console.WriteLine("Answer: s= " + s);
            
        }

    }
}
