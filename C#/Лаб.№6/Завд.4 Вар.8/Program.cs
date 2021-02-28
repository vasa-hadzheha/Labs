using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._4_Вар._8
{
    class Program
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="elCount"></param>
    /// <returns></returns>
        static float[] getField(int elCount)
        {
            float[] arr = new float[elCount];
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i] = rand.Next(-5, 5);
            }
            return arr;
        }
        static void printField(float[] arr)
        {
            Console.Write("Вектор  = [ ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.Write("]\n");
        }
        static void sortField(float[] a)
        {
            int ps = 0;
            int pe = a.Length - 1;
            while (ps < pe)
            {
                while (ps < pe && Math.Abs(a[ps]) <= 1) ps++;
                if (ps < pe)
                {
                    while (ps < pe && Math.Abs(a[pe]) > 1) pe--;
                    if (ps < pe)
                    {
                        float z = a[pe];
                        a[pe] = a[ps];
                        a[ps] = z;
                        ps++;
                        pe--;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Кількість елементів: ");
            int n = Convert.ToInt32(Console.ReadLine());
            float [] k = getField(n);
            printField(k);
            sortField(k);
            printField(k);
        }
    }
}
