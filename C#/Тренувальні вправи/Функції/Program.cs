using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функції
{
    class Program
    {
        static float[] getVec(int rowCount)
        {
            float[] arr = new float[rowCount];
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                    arr[i] = rand.Next(-10, 20);
            }
            return arr;
        }
        static void printVec(float[] arr)
        {

            for (int j = 0; j < arr.GetLength(0); j++)
            {
                Console.Write("{0,7:f}  ", arr[j]);
            }
            Console.WriteLine();

        }
        static float getUnpairEl(float[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count += 1;
                }
            }
            return count;
        }
        static void getBiggerVec(int count_1,int count_2)
        {
            if (count_1 > count_2)
            {
                Console.WriteLine("Перший масив має більше непарних елементів ніж другий");
            }
            else
            {
                Console.WriteLine("Другий масив має більше непарних елементів ніж перший");
            }
        }
        static int getCount(float[] arr,float[] v)
        {
            /*
            float[] c = new float[2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                    if (arr[i]%2!=0)
                    {
                        count_0 += 1;
                    }
            }
            for (int j = 0; j < v.GetLength(0); j++)
            {
                if (v[j] % 2 != 0)
                {
                    count_1 += 1;
                }
            }
            c[0] = count_0;
            c[1] = count_1;*/
            float count_0 = getUnpairEl(arr);
            float count_1 = getUnpairEl(v);
            if (count_0 > count_1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        static void getBigger(float[]count)
        {
            if(count[0]>count[1])
            {
                Console.WriteLine("Перший масив має більше непарних елементів ніж другий");
            }
            else
            {
                Console.WriteLine("Другий масив має більше непарних елементів ніж перший");
            } 
        }
            static void Main(string[] args)
        {
            Console.Write("Кількість рядків 1-го масиву: ");
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість рядків 2-го масиву: ");
            int r2 = Convert.ToInt32(Console.ReadLine());
            float[] v1 = getVec(r1);
            float[] v2 = getVec(r2);
            printVec(v1);
            printVec(v2);
            float[] count = getCount(v1, v2);
            getBigger(count);
        }
    }
}
