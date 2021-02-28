using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._6_Вар._8
{
    class Program
    {
        static void printvec(float[] arr)
        {

            for (int j = 0; j < arr.GetLength(0); j++) //Як змінюються номери стовпців
            {
                Console.Write("{0,7:f}  ", arr[j]);
            }
            Console.WriteLine();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowCount"></param>
        /// <param name="colCount"></param>
        /// <returns></returns>
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
        static float[] getSumOfMatrix(float[,] arr)
        {
            float s = 0;
            int k = 0;
            bool isMinus = true;
            float[] c = new float[arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {   
                    s += arr[j, i];
                    /*if (arr[j,i]>0)
                    {
                        isMinus = false;
                        break;
                    }*/
                    if (j == arr.GetLength(0) - 1 && isMinus==true)
                    {
                        c[k] = s;
                        s = 0;
                        k += 1;
                    }
                }
            }
            return c;
        }
        static void Main(string[] args)
        {
            Console.Write("Кількість рядків: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість стовпців: ");
            int c = Convert.ToInt32(Console.ReadLine());
            float[,] matrix = getMatrix(r, c);
            printMatrix(matrix);
            Console.WriteLine("Сума");
            float[] sum = getSumOfMatrix(matrix);
            printvec(sum);
        }
    }
}
