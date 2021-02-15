using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._3_Вар._8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Не працює
            Console.Write("x=");
            float x = float.Parse(Console.ReadLine());
            double e = 0.000001;
            double d = x;
            int n = 2;
            double el = 100000000000;
            
            while (Math.Abs(1 - x *x/ (n - 1)* (n-1) * Math.PI * Math.PI) > e && n < 1000)
            {
                el = (1 - (x * x) / (((n - 1) * (n - 1)) * (Math.PI * Math.PI)));
                d *= el;
                n++;
                Console.WriteLine("d= " + d);
            }
            
            if (Math.Abs(el) > e)
            {
                Console.WriteLine("Endless Loop (done more than 1000 operations");
            }
            else
            {
                Console.WriteLine("Loop end");
            }
            if (Math.Sin(x) - d < e)
                Console.WriteLine("Рівність справедлива d=sin(x)"); 
            else
                Console.WriteLine("Рівність не справедлива"); 
            Console.WriteLine("sin(x)= "+d);
        }
    }
}
