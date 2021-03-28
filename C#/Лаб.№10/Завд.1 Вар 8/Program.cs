using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._1_Вар_8
{
    class Program
    {
        static void Main(string[] args)
        {
            StraightInFlatness e = new StraightInFlatness(2);
            StraightInFlatness j = new StraightInFlatness(3);
            //j.input();
            e.input();
            e.print();
            //e.parallelism(j);
            e.belonging(5, -1);

        }
    }
}
