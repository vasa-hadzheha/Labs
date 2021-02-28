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
        static float[,] sortMatrix(float[,] arr)
        {
            int ps = 0;
            int pe = arr.GetLength(0) - 1;
            int psIN = 1;
            int peIN = arr.GetLength(1) - 2;
            /*  while (ps < pe)
              {
                  while (ps < pe && psIN < arr.GetLength(1) && arr[ps, psIN] > arr[pe, peIN]) ps++;
                  {

                      if (psIN >= arr.Length)
                      {
                          ps++; psIN = 1;
                      }
                      psIN += 2;
                      if (ps < pe)
                      {
                          while (ps < pe && peIN > 0 && arr[pe, peIN] < arr[ps, psIN]) pe--;
                          {

                              if (peIN < 0)
                              {
                                  peIN = arr.GetLength(1) - 2;
                              }
                              peIN -= 2;
                              if (ps < pe && psIN < arr.GetLength(1) && peIN > 0)
                              {
                                  float z = arr[pe, peIN];
                                  arr[pe, peIN] = arr[ps, psIN];
                                  arr[ps, psIN] = z;
                                  psIN += 2;
                                  peIN -= 2;
                              }
                              if (peIN < 0)
                              {
                                  peIN = arr.GetLength(1) - 2;
                              }

                          }
                      }

                  }
              }*/
            while (ps < pe)
            {
                while (ps < pe && psIN < arr.GetLength(1)) ps++;
                {

                    while (ps < pe && psIN < arr.GetLength(1) && arr[ps, psIN] > arr[pe, peIN]) psIN += 2;
                    {
                        if (psIN >= arr.Length)
                        {
                            psIN = 1;
                        }
                        if (ps < pe)
                        {
                            while (ps < pe && peIN > 0) pe--;
                            {
                                while (ps < pe && peIN > 0 && arr[pe, peIN] < arr[ps, psIN]) peIN -= 2;
                                {
                                    if (peIN < 0)
                                    {
                                        peIN = arr.GetLength(1) - 2;
                                    }


                                    float z = arr[pe, peIN];
                                    arr[pe, peIN] = arr[ps, psIN];
                                    arr[ps, psIN] = z;
                                    psIN += 2;
                                    peIN -= 2;

                                }
                            }
                        }
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
            Console.WriteLine("Посортована матриця");
            float[,] sortedMatr = sortMatrix(matrix);
            printMatrix(sortedMatr);
        }
    }
}
