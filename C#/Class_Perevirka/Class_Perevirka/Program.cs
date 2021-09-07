using System;

namespace Class_Perevirka
{
    class Program
    {
        class Tools
        {
            private string[] a = new string [3];
            private string b = "4";
            private string c = "5";
            
            public string this[int i]
            {
                get
                {
                    if(i>=0 && i < 3)
                    {
                        return a[i];
                    }
                    if (i == 4)
                    {
                        return b;
                    }
                    if (i == 5)
                    {
                        return c;
                    }
                    else
                    {
                        throw new Exception("incorrect index");
                    }
                }
                set
                {
                    if(i>=0 && i < 5)
                    {
                        switch (i)
                        {
                            case 0: a[i] = value;
                                break;
                            case 1:
                            case 2: if(Convert.ToInt32(value)>0) a[i]=value;
                                else
                                {
                                    throw new Exception("Value is incorrect ---(value<0)---");
                                }
                                break;
                            case 3:
                                if (Convert.ToInt32(value) > 0) value=b;
                                else
                                {
                                    throw new Exception("Value is incorrect ---(value<0)---");
                                }
                                break;
                            case 4:
                                if (Convert.ToInt32(value) > 0) value=c;
                                else
                                {
                                    throw new Exception("Value is incorrect ---(value<0)---");
                                }
                                break;
                            default:
                                throw new Exception("something wrong");

                        }

                    }
                }

            }
        }
        static void Main(string[] args)
        {
            Tools a = new Tools();
            a[1] = "123";
            a[0] = "tovar";
            a[2] = "300";
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Tools b = new Tools();
            Console.WriteLine(b[5]);
            Console.WriteLine(b[4]); 
            Console.ReadLine();
        }
    }
}
