using System;

namespace Lesson2
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;     // если проблемы с русским
            Console.WriteLine("Hello World!");
            string s = new string('a', 32);
            Console.WriteLine($"вот новая строка из конструктора = {s}");
            Console.WriteLine($"ее длина  = {s.Length} символов и размер = {s.Length * 2} байт ");

            

            // попытка безопасного преобразования строки в число
            s = Console.ReadLine();
            int output;
            bool b = int.TryParse(s, out output);
            if (b)
            {
                Console.WriteLine($"Преобразование возможно {output}"); ;
            }
            else Console.WriteLine($"ошибка ");
            //Console.WriteLine(output);
            // число в строчку
            
            s = $"Вам {output} лет?";
            Console.WriteLine(s);
            string s1 = s.Substring(0, 1);
            Console.WriteLine(s1);
            int n = s.IndexOf($"{output}");
            Console.WriteLine(n);
                
            // null or Empty????
            s = string.Empty;
            Console.WriteLine($" здесь =  {s.Length}");
            switch (n)
            {
                case 4:
                    n = 10;
                    break;
                default:
                    break;
            }
            Console.WriteLine(n);
        }
    }
}
