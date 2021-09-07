using System;

namespace Мінне_поле
{
    class Program
    {
        static int[,] getMatrix(int rowCount, int colCount)
        {
            int[,] arr = new int[rowCount, colCount];
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(0,2);
                }
            }
            return arr;
        }
        static void printMatrix(int[,] arr, bool Mina = false)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (Mina)
                    {
                        if (arr[i, j] == 7)
                            Console.Write("{0,5:s}", "*");
                        else
                            Console.Write("{0,5:s}", "-");
                    }
                    else
                        Console.Write("{0,5:d}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static bool play(int[,] Matrix, int stepsCount,int lives=1)
        {
            int loseTimes = 0;
            for (int i = 0; i < stepsCount; i++)
            {
                Console.Write("row=");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("col=");
                int col = Convert.ToInt32(Console.ReadLine());
                if (Matrix[row - 1, col - 1] == 1)
                {
                    Console.WriteLine("Boom");
                    loseTimes++;
                    if (loseTimes == lives)
                    {
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("ok");
                }
                Matrix[row - 1, col - 1] = 7;
                printMatrix(Matrix, true);
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Кількість рядків: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість стовпців: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = getMatrix(r, c);
            printMatrix(matrix,true);
            if (play(matrix, 3,2))
                Console.WriteLine("Win!");
            else 
            {
                Console.WriteLine("Lose!");
            }    
            printMatrix(matrix);
        }
    }
}
