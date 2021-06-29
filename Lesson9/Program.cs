using System;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            int x = 257;
            Console.WriteLine(x.GetType());

            // инициализация двух объектов класса Object

            object obj = new object();
            _ = new object();   //what this ????

            //Console.Beep();
            //Console.Clear();
           

            // явное преобразование int к byte!
            byte y = 25;
            byte z = (byte)((byte)x + y);
            byte w = (byte)(x + y);
            w = (byte)x;
            Console.WriteLine(w);

            w.ToString();
            string s = "qwerty";
            s.ToString();

            float f = 10f;
            Types(f);
            double d = 9;
            Types(d);
            f = (float)d;
            Types(f);
            d = f;
            Types(d);
            object objX = x;

            Console.WriteLine($"obj type: { objX.GetType()}");

            object objS = s;
            string ss = (string)objS;
            


        }
        static void Types(object obj)
        {
            Console.WriteLine($"{obj}: {obj.GetType()}");
        }
    }
}
