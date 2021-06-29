using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 100;
            #region Регион


            int minPrice = 20;
            Console.WriteLine("Введите цену товара: ");
            int price = int.Parse(Console.ReadLine());
            if (minPrice <= price && price <= money)
            {
                Console.WriteLine("Покупаем");
            }
            else
            {
                Console.WriteLine("Не покупаем, но есть нюанс ");
            }
            if (price != 0 && money % price == 1)
            {
                Console.WriteLine("Покупаем точно");
            }
            else
            {
                Console.WriteLine("Не покупаем. ");
            }
            #endregion


        }
    }
}
