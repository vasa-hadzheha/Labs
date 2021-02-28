using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._1_Вар._8
{
    class Program
    {
        static float[,] getMatrix(int rowCount, int colCount)
        {
            float[,] arr = new float[rowCount, colCount];
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
        static float dobOfMatrix(float[,] arr)
        {
            float dob = 1;
            for (int i = 0; i < arr.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j <=i ; j++) //Як змінюються номери стовпців
                {
                    if (arr[i, j] > 0)
                    {
                        dob *= arr[i, j];
                    }
                    
                }
            }
            Console.WriteLine($"dob={dob}");
            return dob;
        }

        static void Main(string[] args)
        {
            Console.Write("Кількість рядків: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість стовпців: ");
            int c = Convert.ToInt32(Console.ReadLine());
            float [,] matrix = getMatrix(r, c);
            printMatrix(matrix);
            dobOfMatrix(matrix);

        }
    }
}
