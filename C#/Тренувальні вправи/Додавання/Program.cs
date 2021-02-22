using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Додавання
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість прикладів для розв'язання: ");
            int n = int.Parse(Console.ReadLine());
            double[] ansTrue = new double[n];
            double[] ansFalse = new double[n];
            double[] a = new double[n];
            double[] b = new double[n];
            double[] c = new double[n];
            double[] ans = new double[n];
            double[] vt = new double[n];
            double[] vf = new double[n];
            Random rand = new Random(DateTime.Now.Millisecond);
            
            for (int i = 0; i < n; i++)
            {

                a[i] = rand.Next(1, 11);
                b[i] = rand.Next(1, 11);
                c[i] = a[i] + b[i];
                Console.Write($"{a[i]}+{b[i]}= ");
                ans[i] = int.Parse(Console.ReadLine());
                if (ans[i] == c[i])
                {
                    Console.WriteLine("Відповідь вірна!");
                    ansTrue[i] = i;
                    ansFalse[i] = 111;
                    vt[i] += c[i];
                    vf[i] = 444;
                }
                else
                {
                    Console.WriteLine("Відповідь не вірна!");
                    ansFalse[i] = i;
                    ansTrue[i] = 222;
                    vf[i] += ans[i];
                    vt[i] = 333;
                }


            }
            foreach (int i in vt)
            {
                Console.WriteLine("T"+i);
            }
            foreach (int i in vf)
            {
                Console.WriteLine("F"+i);
            }
            Console.WriteLine("Вірні відповіді:");
            for (int j = 0; j < n; j++)
            {
                if (j == ansTrue[j] )
                {
                    Console.WriteLine($"{a[j]}+{b[j]}={c[j]}");
                }
            }
            Console.WriteLine("Хибні відповіді:");
            for (int k = 0; k < n; k++)
            {
                if (k == ansFalse[k] )
                {
                    Console.WriteLine($"{a[k]}+{b[k]}={ans[k]}");
                }
            }
            for (int l = 0; l < n; l++)
            {                
                Console.WriteLine($"Вірні відповіді:{a[l]}+{b[l]}={vt[l]}       Хибні відповіді:{a[l]}+{b[l]}={vf[l]}");     
                
            }
            
            Console.WriteLine(String.Format("{0:0   .   0}", 12.3));
        }
    }
}
