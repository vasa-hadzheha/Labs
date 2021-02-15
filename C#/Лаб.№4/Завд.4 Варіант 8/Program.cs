using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._4_Варіант_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n=");
            float n = float.Parse(Console.ReadLine());
            int y;
            if (n < 0)
                y = 3;
            else
                if (n < 5)
                y = 0;
            else
                if (n < 10)
                y = 1;
            else
                if (n < 15)
                y = 2;
            else
                y = 3;
            Console.WriteLine("y= "+y);
        }
    }
}
