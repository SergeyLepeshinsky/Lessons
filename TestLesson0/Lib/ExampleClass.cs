using System;
using System.Collections.Generic;
using System.Text;

namespace TestLesson0
{
    class ExampleClass
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }
    }
    class ExampleClass2
    {
        public static void Intr(int x) => Console.WriteLine($"x + max = {x + int.MaxValue}");
    }
    class ExampleClass3
    {
        public static void L2() { Lesson2.Program.Main(); }
    }
}
