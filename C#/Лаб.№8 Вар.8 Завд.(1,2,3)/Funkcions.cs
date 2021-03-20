using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб._5_Вар._8_Завд._1_2_3_
{
    class Funkcions
    {
        public static double getmax(double x, double y, double z)
        {
            double max=x;
            if (x<y)
            {
                max = y;
            }
            else if (max<z)
            {
                max = z;
            }
            return max;
        }
        //Функція не працює видає Nan
        public static double angle(double x1, double y1, double x2, double y2,double x3, double y3)
        {
            double a1 = x2 - x1;
            double a2 = y2 - y1;
            double b1 = x3 - x1;
            double b2 = y3 - y1;
            double ab = a1 * b1 + a2 * b2;
            Console.WriteLine(ab);
            double mod_a = Math.Sqrt(a1 * a1 + a2 * a2);
            Console.WriteLine(mod_a);
            double mod_b = Math.Sqrt(b1 * b1 + b2 * b2);
            Console.WriteLine(mod_b);
            double angle = ((Math.Acos(ab / (mod_a * mod_b))) * 180) / Math.PI;
            Console.WriteLine(angle);
            return angle;
        }
    }
}
