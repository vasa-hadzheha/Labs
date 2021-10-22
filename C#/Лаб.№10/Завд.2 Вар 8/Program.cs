using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._2_Вар_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            var s = 1;
            while (i < 3)
            {
                s += ++i;
            }
            Monitor m = new Monitor("Asus", 2016, 2019, 5000, 20, 19);
            m.age(2021);
            m.enableDisp(20,19);
            m.koef(20,19);
        }
    }
}
