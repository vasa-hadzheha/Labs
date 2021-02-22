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
                arr[i] = rand.Next(-10, 15);
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
        static void Main(string[] args)
        {
            Console.Write("Кількість елементів: ");
            int n = Convert.ToInt32(Console.ReadLine());
            float [] k = getField(n);
            printField(k);
            float[] arr = new float[n];
            float[] brr = new float[n];
            float[] crr = new float[n];
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(k[i])<=1)
                {
                    arr[i]=k[i];
                }
                else
                {
                    brr[i]=k[i];
                }
            }
            printField(arr);
            printField(brr);
            for (int j = 0; j < n; j++)
            {
                crr[j]=arr[j];
            }
            for (int l = crr.GetLength(0)+1; l < n; l++)
            {
                crr.Append(brr[l]);
            }
            printField(crr);
        }
    }
}
