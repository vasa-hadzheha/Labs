using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перевірочна_робота
{
    class Class_arr
    {
        
            private string[] a;
            public string this[int i]
            {
                get
                {
                    if (i >= 0 && i < 3)
                    {
                        return a[i];
                    }
                    else
                    {
                        throw new Exception("Incorrect number");
                    }
                }
                set
                {
                    if (i >= 0 && i < 3)
                    {
                        switch (i)
                        {
                            case 0:
                                a[i] = value;
                                break;
                            case 1:
                            case 2:
                                if (Convert.ToInt32(value) > 0) a[i] = value;
                                else
                                {
                                    throw new Exception("");
                                }
                                break;
                            default:
                                throw new Exception("");

                        }
                    }
                }
            }
        }






}
