using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._2_Вар._8
{
    class Program
      
    {/// <summary>
    /// 
    /// </summary>
    /// <param кількість елементів="elCount"></param>
    /// <returns></returns>
        // створення масиву за заданою умовою
        static double[] getField(int elCount,double x)
        {
            double[] arr = new double[elCount];
            int cosFactorial = 1;
            for (int i = 1; i <= arr.GetLength(0); i++)
            {
                cosFactorial *= i;
                arr[i-1] = Math.Pow(-1,i+1) * Math.Sin(i*x) * Math.Cos(cosFactorial) * x;
            }
            return arr;
        }
        static void printField(double[] arr)
        {
            Console.Write("Масив A = [ ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.Write("]\n");
        }
        static void Main(string[] args)
        {
            Console.Write("Кількість елемнтів i= ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть x= ");
            double x = double.Parse(Console.ReadLine());
            double [] a = getField(i, x);
            printField(a);
            double min = a[0];
            for (int j  = 1; j  < a.GetLength(0); j ++)
            {
                if (min>a[j])
                {
                    min = a[j];
                }
            }
            Console.WriteLine($"Мінімальне значення = {min}");
        }
    }
}
