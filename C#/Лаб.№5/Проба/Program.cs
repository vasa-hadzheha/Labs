using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проба
{
    class Program
    {
        static void printMatrix(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < arr.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    Console.Write("{0,7:f}  ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void printvec(double[] arr)
        {
            for (int j = 0; j < arr.GetLength(0); j++) //Як змінюються номери стовпців
            {
                Console.Write("{0,7:f}  ", arr[j]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("введіть розмірність квадратної матриці: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] a = new double[n, n];
            for (int i = 0; i < a.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < a.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    if ((i + 1 + j + 1) % 2 == 0)
                    {
                        a[i, j] = a[i, j] + i + 1;
                    }
                    else
                    {
                        a[i, j] = a[i, j] + Math.Pow(j + 1, 2);
                    }
                }
            }
            printMatrix(a);

            double[] b = new double[a.GetLength(0)];
            double dob = 1;

            for (int i = 0; i < n; i++) //Як змінюються номери рядків
            {

                for (int j = 0; j < n; j++) //Як змінюються номери стовпців
                {
                    dob *= a[j, i];
                }
                b[i] = dob;
                dob = 1;
            }
            Console.WriteLine("*****");
            printvec(b);
            double max = b[0];
            for (int i = 0; i < n; i++)
            {
                if(max<b[i] && b[i]%2==0)
                {
                    max = b[i];
                }
            }
            Console.WriteLine("Найбільший парний елемент масиву b="+max);
        }
    }
}
