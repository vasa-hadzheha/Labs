using System;
using System.Collections.Generic;
using System.Text;

namespace Inp_Text
{
    class Text
    {
        private string text;
        public int countTimes;
        //Задаємо умову
        public string T
        {
            get { return text; }
            set
            {
                if (value != "hello") throw new Exception("Incorrect text");
                text = value;
            }
        }
        public Text(string word,int countTimes)
        {
            
        }
        public void correctText()
        {
            for (int i = 0; i < countTimes; i++)
            {
                Console.Write("Input text: ");
                string wrotedText=Console.ReadLine();
                if(wrotedText==text)
                {
                    Console.WriteLine("Corret!!!");
                }
                else
                {
                    Console.WriteLine("Uncorrect!!!");
                    break;
                }
            }
        }
    }
}
