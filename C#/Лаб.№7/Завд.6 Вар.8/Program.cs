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
        static float getSumOfMatrix(float[,] arr)
        {
            float s = 0;
            int k = 0;
            float[] c = new float[arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {   
                    if (arr[j,i]<0 && j==i)
                    {
                        s += arr[j, i];
                    }
                    
                }
            }
            return s;
        }
        static void Main(string[] args)
        {
            Console.Write("Кількість рядків: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість стовпців: ");
            int c = Convert.ToInt32(Console.ReadLine());
            float[,] matrix = getMatrix(r, c);
            printMatrix(matrix);
            float sum = getSumOfMatrix(matrix);
            if (sum==0)
            {
                Console.WriteLine("Елементів що задовльняють умову не знайшлося, тому sum=0;");
            }
            Console.WriteLine("Відповідь: "+sum);
        }
    }
}
