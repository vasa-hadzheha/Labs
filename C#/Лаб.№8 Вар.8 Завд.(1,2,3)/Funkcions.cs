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
        public static double angle(double x1, double y1, double x2, double y2)
        {
            double ab = x1 * y1 + x2 * y2;
            double mod_a = Math.Sqrt(x1 * x1 + y1 * y1);
            double mod_b = Math.Sqrt(x2 * x2 + y2 * y2);
            double angle = Math.Acos(ab / mod_a * mod_b)* Math.PI / 180;
            return angle;
        }
        public static double number(double elCount)
        {
            double[] arr = new double [(int)elCount];
            arr[0] = 0;
            arr[1] = 9;
            arr[2] = 9;
            for (int i = 0; i < elCount-3; i++)
            {
                arr[i + 3] = arr[2] + 4 * arr[i];
                arr[2] = arr[i + 3];
                Console.WriteLine(arr[i+3]);
            }
        }
    }
}
