using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
{
    class Week  // класс состоит из двух конструкторов 
    {
        public Week(string sn)
        {
            //Console.WriteLine();
            int n;
            bool bn;
            do
            {
                bn = int.TryParse(sn, out n);
                if (bn && n > 0 && n < 7) 
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверное n. Введите n = ");
                    sn = Console.ReadLine();
                }
            } while (true);
            string[] day = new string[7] { "Понедельник", "Вторник", "Среда", "Четврг", "Пятница", "Суббота", "Воскресенье" };
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(day[i]);
            }
            for (int i = 0; i < n; i++) //просто звездочки 
            {
                Console.Write("*\t");
            }
        }
        public Week()
        {
            Console.WriteLine();
            string[] day = new string[7] { "Понедельник", "Вторник", "Среда", "Четврг", "Пятница", "Суббота", "Воскресенье" };
            foreach (var d in day)
            {
                Console.WriteLine(d);
            }
        }
    }
}
