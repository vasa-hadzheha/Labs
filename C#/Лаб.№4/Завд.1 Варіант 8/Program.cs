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
        //Обчислити площу та периметр ромба, якщо задано довжину сторін та один з кутів.
        /* Задаємо сторону ромба
         * Задаємо кут ромба
         * Обчмслюємо периметр (P=a*4) 
         * Обчислюємо площу (a**2*sin())*/
        {
            Console.Write("side of rhomb a=");
            float a = float.Parse(Console.ReadLine());
            Console.Write("rhomb angle l=");
            float l = float.Parse(Console.ReadLine());
            float p = a*4;
            Console.WriteLine("p={0}", p);
            double s = Math.Pow(a, 2) * Math.Sin(l*Math.PI/180);
            Console.WriteLine("s={0}", s);
        }
    }
}
