using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна__6
{
    class Program
    {   // функція створення вектора
        static float[] getField(int elCount)
        {
            float[] arr = new float[elCount];
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                 arr[i] = rand.Next(-20, 10); 
            }
            return arr;
        }
        // функція виводу вектора
        static void printField(float[]arr)
        {
            Console.Write("Вектор a = [ ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.Write("]\n");
        }

            static void Main(string[] args)
        {
           
            Console.Write("Кількість координат векотра n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            float [] a = getField(n);
            printField(a);

            // Виконуємо операції з масивами
            double dob = 1;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                
                if (a[i] < 0)
                    dob *= a[i];
               
            }
            // Вивиодимо результат
            Console.WriteLine($"Dob= {dob}");

        }   
            
    }
}
