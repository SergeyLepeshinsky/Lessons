using System;



namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            // пример одного цикла с continue и без
            Console.Write("Введите n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 0; i--) 
            {
                if ((i % 2 == 0) | (i == 5))   
                {
                    continue;
                }
                Console.Write($"{i}\t");
                
            }
            
            Console.WriteLine();
            for (int i = n; i >= 0; i--)
            {

                if (!((i % 2 == 0) | (i == 5))) 
                {
                    Console.Write($"{i}\t");
                }
            }
            // еще цикл
            do
            {
                //break;    //а вот так ни разу 
                Console.WriteLine("Хотя бы один раз ");
            } while (10 > 11);

            // пример foreach с классом Week

            Console.Write("Введиде кол-во дней : ");
            string s = Console.ReadLine();
            // в случае не использования static необходимо создать объекты класса Week 
            //Week.Weeks(s);

            Week week = new Week(s);            
            Week week1 = new Week();
            

            // пример массива 

            string[] vs = new string[] { "vs", "vs1"};
            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine(vs[i]);
            }

        }
    }
}
