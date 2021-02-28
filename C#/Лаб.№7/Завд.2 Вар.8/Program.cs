using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._2_Вар._8
{
    class Program
    {
        static double[,] getMatrix(int rowAndColCount)
        {
            double[,] arr = new double[rowAndColCount, rowAndColCount];
            for (int  i = 0, k=1; i < arr.GetLength(0); i++, k++)
            {
                for (int j = 0, l=1; j < arr.GetLength(1); j++,l++)
                {
                    arr[i, j] = Math.Sin((k*k-l*l)/ rowAndColCount);
                }
            }
            return arr;
        }
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
        static double maxElOfMatrix(double[,] arr)
        {
            double max = arr[0,0];
            int ind1 = 0;
            int ind2 = 0;
            for (int i = 1; i < arr.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 1; j < arr.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    if (Math.Abs(max) < Math.Abs(arr[i, j]))
                    {
                        max = Math.Abs(arr[i, j]);
                        ind1 = i;
                        ind2 = j;

                    }
                }
            }
            Console.WriteLine($"maxEl={max},індекс{ind1},{ind2}(Рахувати з нуля)");
            return max;
        }

        static void Main(string[] args)
        {
            Console.Write("rowAndColCount or n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            double [,] matrix = getMatrix(n);
            printMatrix(matrix);
            maxElOfMatrix(matrix);

        }
    }
}
