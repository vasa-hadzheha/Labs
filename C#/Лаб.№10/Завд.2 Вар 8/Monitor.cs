using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завд._2_Вар_8
{
    class Monitor
    {
        public string name;
        public int production_date;
        public int purchase_date;
        public float price;
        public int h;
        public int w;
        public Monitor(string name, int production_date, int purchase_date, float price, int h, int w)
        {
            this.name = name;
            this.production_date = production_date;
            this.purchase_date = purchase_date;
            this.price = price;
            this.h = h;
            this.w = w;
        }
        public void age(int currentYear)
        {
            Console.WriteLine($"Вік монітору:{currentYear-purchase_date} роки");
        }
        public void enableDisp(int hi,int wi)
        {
            if (hi <= h && wi <= w)
            {
                Console.WriteLine("Можна без масштабування");
            }
            else
            {
                Console.WriteLine("Без масштабування не можна");
            }
        }
        public void koef(int hi, int wi)
        {
            float k1 = h / hi;
            float k2 = w / wi;
            Console.WriteLine($"Коефіціенти {k1},{k2}");
        }
    }
}
