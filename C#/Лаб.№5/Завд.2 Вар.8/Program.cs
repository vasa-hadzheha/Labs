using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._2_Вар._8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Великі числа не працюють "OverflowException",122488885763
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int n2 = n;
            double arMean;
            int s=0;
            int countN=0;
            int countAnsw = 0;
            while (n>0)
            {
                s += n % 10;
                n /= 10;
                countN++;
            }
            arMean = s / countN;
            Console.WriteLine("Arithmetic mean="+arMean);
            while (n2>0)
            {
                if (n2%10<arMean)
                {
                    countAnsw++;
                    Console.WriteLine("Number_{0}_<arMean_{1}_",n2%10, arMean);
                }
                n2 = n2 / 10;
                
            }
            Console.WriteLine("Answer= "+countAnsw);

        }
    }
}
