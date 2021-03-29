using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модульна_робота
{
    class Program
    {
        static void Main(string[] args)
        {
            StraightInFlatness e = new StraightInFlatness(3);
            StraightInFlatness j = new StraightInFlatness(3);
            j.input();
            j.print();
            e.input();
            e.print();
            //e.point_of_intersection(j);
            StraightInFlatness b = e + j;
            b.print();
            StraightInFlatness c = e - j;
            c.print();
            e.belonging(5, -1);
        }
    }
}
