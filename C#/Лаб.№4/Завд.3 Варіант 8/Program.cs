using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._3_Варіант_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1=");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("y1=");
            float y1 = float.Parse(Console.ReadLine());
            Console.Write("x2=");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("y2=");
            float y2 = float.Parse(Console.ReadLine());
            Console.Write("x3=");
            float x3 = float.Parse(Console.ReadLine());
            Console.Write("y3=");
            float y3 = float.Parse(Console.ReadLine());
            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            Console.WriteLine("a= " + a);
            Console.WriteLine("b= " + b);
            Console.WriteLine("c= " + c);
            double max = a;
            if (b > max) 
                max = b;
            else 
                if (max > c) 
                    Console.WriteLine("The biggest side = {0}", max);
                else
                    max = c;
                    Console.WriteLine("The biggest side = " + max);




        }
    }
}
