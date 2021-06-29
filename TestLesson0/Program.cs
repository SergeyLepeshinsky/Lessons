using System;




namespace TestLesson0
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            //Calc calc = new Calc();
            Console.WriteLine("x + y = {0}", SomeLib.Calc.Sum(x, y));
            x = 100;
            y = 50;
            Console.WriteLine("x + y = {0}", SomeLib.Calc.Sum(x, y));
            Console.WriteLine("new x + y = {0}", ExampleClass.Sum(x, y));
            Console.WriteLine("x - y = {0}", SomeLib.Calc.Substract(x, y));
            SomeLib.Calc.Privet();
            Console.WriteLine("x * y = {0}", SomeLib2.Calc.Multi(x, y));
            ExampleClass2.Intr(x);
            //Console.ReadKey();
            //Lesson2.Program.Main();
            ExampleClass3.L2();

            
            
        }
    }
}
