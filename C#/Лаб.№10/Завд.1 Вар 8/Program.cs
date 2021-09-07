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
            //StraightInFlatness e = new StraightInFlatness(2);
            //StraightInFlatness j = new StraightInFlatness(3);
            ////j.input();
            //e.input();
            //e.print();
            ////e.parallelism(j);
            //e.belonging(5, -1);
            
            
            
            
            pers a = new pers();
            a[1] = "123";
            a[0] = "tovar";
            a[2] = "300";
            string b = a[0];
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.ReadLine();
        }
    }
    class pers
    {
        private string[] a = new string[3];
        public string this[int i]
        {
            get
            {
                if(i>= 0 && i < 3)
                {
                    return a[i];
                }
                else
                {
                    throw new Exception("OYOYOY");
                }
            }
            set
            {
                if(i >= 0 && i < 3)
                {
                    switch (i)
                    {
                        case 0: a[i] = value;
                            break;
                        case 1:
                        case 2: if(Convert.ToInt32 (value )> 0) a[i] =  value;
                            else
                            {
                                throw new Exception("Incorrect number");
                            }
                            break;
                        default:
                            throw new Exception("something wrong");

                    }
                }
            }
        }
    }
}
