using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._3_Вар._8
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
                arr[i] = rand.Next(-20, 20);
            }
            return arr;
        }
        static void printField(float[] arr)
        {
            Console.Write($"Вектор {arr} = [ ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.Write("]\n");
        }
        static void Main(string[] args)
        {
            Console.Write("Вимір векторів: ");
            int n = Convert.ToInt32(Console.ReadLine());
            float[] a = getField(n);
            float[] b = getField(n);
            float[] c = new float[n];
            Random rand = new Random(DateTime.Now.Second);
            for (int i = 0; i < c.GetLength(0); i++)
            {
                c[i] = rand.Next(-20, 20);
            }           
            float ab = 0;
            float ac = 0;
            float s;
            printField(a);
            printField(b);
            printField(c);
            for (int i = 0; i < n; i++)
            {
                ab += a[i] * b[i];
                ac += a[i] * c[i];
            }
            Console.WriteLine("ab= "+ab);
            Console.WriteLine("ac= " + ac);
            s = 2 * ab - 3 * ac;
            Console.WriteLine("s= "+s);
        }
    }
}
