using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модульна_робота
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
        public StraightInFlatness()
        {
            N = 1;
        }
        public StraightInFlatness(int k)
        {
            N = k;
        }
        public StraightInFlatness(StraightInFlatness r)
        {
            N = r.n;  
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
        // Незакінчена функція
        public void point_of_intersection(StraightInFlatness c1)
        {
            int d = a[0] * a[1] * c1.a[1];
            int x = (a[0] * c1.a[2] - c1.a[1] * a[2]) / d;
            int y = (c1.a[0] * a[2] - a[0] * c1.a[2]) / d;
            Console.WriteLine($"Прямі перетинаються у точці({x};{y})");
        }
        public void belonging(int x, int y)
        {
            int s = a[0] * x + a[1] * y;
            for (int i = 2; i < a.Length; i++)
            {
                s += a[i];
            }
            if (s == 0)
            {
                Console.WriteLine("Точка належить прямій");
            }
            else
            {
                Console.WriteLine("Точка не належить прямій");
            }
        }
        public static StraightInFlatness operator +(StraightInFlatness c1, StraightInFlatness c2)
        {
            int [] a = new int[c1.N];
            for (int i = 0; i < c1.N; i++)
            {
                a[i] = c1.a[i] + c2.a[i];
            }
            return new StraightInFlatness { a = a };
        }
        public static StraightInFlatness operator -(StraightInFlatness c1, StraightInFlatness c2)
        {
            int[] a = new int[c1.N];
            for (int i = 0; i < c1.N; i++)
            {
                a[i] = c1.a[i] - c2.a[i];
            }
            return new StraightInFlatness { a=a };
        }

       /* public static bool operator >(StraightInFlatness c1, StraightInFlatness c2)
        {
            int s1 = 0;
            int s2 = 0;
            for (int i = 0; i < c1.N; i++)
            {
                s1 += c1.a[i];
            }
            for (int i = 0; i < c1.N; i++)
            {
                s2 += c2.a[i];
            }
            return s1 > s2;
        }
        public static bool operator <(StraightInFlatness c1, StraightInFlatness c2)
        {
            int s1 = 0;
            int s2 = 0;
            for (int i = 0; i < c1.N; i++)
            {
                s1 += c1.a[i];
            }
            for (int i = 0; i < c1.N; i++)
            {
                s2 += c2.a[i];
            }
            return s1 < s2;
        }*/



    }
}
