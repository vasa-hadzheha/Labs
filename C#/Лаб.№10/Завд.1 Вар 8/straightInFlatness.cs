using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._1_Вар_8
{
    class StraightInFlatness
    {

        private int n;
        public int[] a { get; set; }
        public int N
        {
            get
            {
                return n;
            }
            set
            {
                if (value < 0) throw new Exception("The value is incorrect!");
                n = value;
            }
        }
        public StraightInFlatness(int k)
        {
            N = k;
        }

        public void input()
        {
            a = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Введіть х{i + 1}");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void print()
        {
            Console.WriteLine("Вектор");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]},");

            }
            Console.WriteLine("");
        }
        public void point_of_intersection()
        {

        }
        public void parallelism(int [] vec)
        {
            for (int i = 1; i < a.Length; i++)
            {
                if(a[i-1] / vec[i-1] == a[i] / vec[i])
                {
                    Console.WriteLine("Паралельні");
                }
                else
                {
                    Console.WriteLine("Непаралельні");
                    break;
                }
            }
        }
        public void belonging(int x,int y)
        {
            int s = a[0] * x + a[1] * y;
            for (int i = 2; i < a.Length; i++)
            {
                s += a[i];
            }
            if(s==0)
            {
                Console.WriteLine("Точка належить прямій");
            }
            else
            {
                Console.WriteLine("Точка не належить прямій");
            }
        }

    }
}
