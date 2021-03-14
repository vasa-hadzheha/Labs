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
    /// <param name="rowCount"></param>
    /// <param name="colCount"></param>
    /// <returns></returns>
        static float[,] getMatrix(int rowCount)
        {
            float[,] arr = new float[rowCount, rowCount];
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-10, 20);
                }
            }
            return arr;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        static void printMatrix(float[,] arr)
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
        static float[,] sortColumnMatr(float[,] matr, int col)
        {
            for (int i = 0; i < matr.GetLength(0) - 1; i++)
            {
                //На і-вому кроці треба знайти індекс мінімального від і-го то кінця
                int indexMax = i;
                for (int j = i + 1; j < matr.GetLength(0); j++)
                {
                    if (matr[j, col] > matr[indexMax, col])
                        indexMax = j;
                }
                //
                if (i != indexMax)
                {
                    float z = matr[i, col];
                    matr[i, col] = matr[indexMax, col];
                    matr[indexMax, col] = z;
                }
            }
            return matr;
        }

        static float[,] sortColumns(float[,] matr)
        {
            for (int j = 1; j < matr.GetLength(1); j += 2)
            {
                sortColumnMatr(matr, j);
            }
            return matr;
        }
        static void Main(string[] args)
        {
            Console.Write("Кількість рядків та стовбців: ");
            int r = Convert.ToInt32(Console.ReadLine());
            float[,] matrix = getMatrix(r);
            printMatrix(matrix);
            Console.WriteLine("Посортована матриця");
            float[,] sortedMatr = sortColumns(matrix);
            printMatrix(sortedMatr);
        }
    }
}
