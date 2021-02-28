using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._5_Вар._8
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
        static float[] getCharOfMatrix(float[,] arr)
        {
            float s = 0;
            int k = 0;
            float[] c = new float[arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[j,i]<0 && arr[j,i]%2!=0)
                    {
                        s += Math.Abs(arr[j, i]);
                    }
                    if (j == arr.GetLength(0)-1)
                    {
                        c[k]= s;
                        s = 0;
                        k += 1;
                    }
                }
            }
            return c;
        }
        static float[,] sortMatrix(float[,] arr,float []ch)
        {
            for (int k = 0; k < ch.GetLength(0); k++)
            {
                float max = ch[0];
                int m = 0;
                for (int i = 1; i < ch.GetLength(0); i++)
                {
                    int l = 0;
                    if (max < ch[i])
                    {
                        max = ch[i];
                        m = i;
                    }
                    if(i== ch.GetLength(0)-1)
                    {
                        ch[m] = -1000;
                    }
                   /* while (l<l+1)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            float z = arr[l, j];
                            arr[l, j] = arr[l, m];
                            arr[l, m] = z;

                        }
                        if (l < arr.GetLength(0))
                        {
                            break;
                        }
                        l += 1;
                    }*/
                }
                Console.WriteLine("max=" + max);
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        float z = arr[i, j];
                        arr[i, j] = arr[i, m];
                        arr[i, m] = z;

                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Console.Write("Кількість рядків: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість стовпців: ");
            int c = Convert.ToInt32(Console.ReadLine());
            float[,] matrix = getMatrix(r, c);
            printMatrix(matrix);
            float[] characteristic = getCharOfMatrix(matrix);
            Console.WriteLine("Характеристика ");
            printvec(characteristic);
            Console.WriteLine("Посортована матриця за характеристикою ");
            float[,] sortedMatr = sortMatrix(matrix, characteristic);
            printMatrix(sortedMatr);
        }
    }
}
