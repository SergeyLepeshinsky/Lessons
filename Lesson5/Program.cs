using System;
using NewClass = NewNamespace.NewClass;

namespace Lesson5

{
    class Program
    {
        // объявление переменных на глобальном уровне
        //static int n = 10;    // или 
        //static int n = int.Parse(Console.ReadLine());

        //static int[,] mv = new int[10, 12];

        static void Main(string[] args)
        {
            /*#region матрица

            Matrix(10);
           
            Console.WriteLine("Hello World!");
            int x = Double(Double(Double(10)));
            Console.WriteLine($"x  = {x}");

            #endregion*/

            #region задания к уроку 6

            Task2(); Task5(); Task6(); Task7();
            NewClass.Task8(); NewClass.Task9(); NewClass.Task12();

            #endregion




        }
        static void Matrix(int n)
        {
            Console.WriteLine("Матрица умножения N на N: ");
            Header(n);
            Vivod(Multi(n));
        }

        static int[,] Multi(int n)
        {
            int[,] vs = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    vs[i, j] = (i + 1) * (j + 1);
                }
            }
            return vs;
        }
        static void Header(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\t{i + 1}");
            }
            Console.WriteLine();
        }
        static void Vivod(int[,]q)
        {
            for (int i = 0; i < q.GetLength(0); i++)
            {
                Console.Write($"{i + 1}");
                for (int j = 0; j < q.GetLength(1); j++)
                {
                    Console.Write($"\t{q[i, j]}");
                }
                Console.WriteLine();
            }
        }
       
        /*static void Variant(int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    q[i, j] = (i + 1) * (j + 1);
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\t{i + 1}");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}");
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"\t{q[i, j]}");
                }
                Console.WriteLine();
            }
        }*/
        
        static int Double(int x)
        {
            return x = x * 2;
        }
        static void String(string s)
        {
            s = s + "Вася!";
        }

        /// <summary>
        /// Найти два наибольших элемента массива
        /// </summary>
        public static void Task2()
        {
            int[] a = new int[] { 55, 12, 13, 2, 200, 9, 15, 19, 600 };
            int max = a[0];
            int t = 0; 
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max) 
                {
                    max = a[i];
                    t = i;
                }
            }
            Console.WriteLine($"Первый максимальный: {max}");
            if (t == 0) 
            {
                max = a[1];
            }
            else
            {
                max = a[0];
            }
            
            for (int i = 0; i < a.Length; i++)
            {
                if (i == t) 
                {
                    continue;
                }
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine($"Второй максимальный: {max}");

        }

        /// <summary>
        /// Создать и заполнить массив случайными целыми числами
        /// </summary>
        public static void Task5()
        {
            //пример вызова генератора случайных чисел, он понадобится в данной задаче
            Random rnd = new Random();
            int r = rnd.Next(1, 10);//случайное число от 1 до 10
            int[] a = new int[r];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 10);
                Console.Write($"{a[i]}\t");
            }
        }

        /// <summary>
        /// Проверить, что в массиве нет одинаковых чисел
        /// </summary>
        public static void Task6()
        {

            int t;
            bool k = false;
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 5, 19, 6 };
            for (int i = 0; i < a.Length; i++)
            {
                t = a[i];
                for (int j = i + 1; j < a.Length; j++) 
                {
                    if (a[j] == t) 
                    {
                        k = true;   
                    }
                }
            }
            if (k)
            {
                Console.WriteLine("Есть ");
            }
            else
            {
                Console.WriteLine("Нет ");
            }
        }

        /// <summary>
        /// Переставить элементы массива в обратном порядке используя вспомогательный массив
        /// </summary>
        public static void Task7()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int[] b = new int[a.Length];
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]}\t");
            }
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                b[a.Length - 1 - i] = a[i];
                //Console.Write($"{b[i]}\t");
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{b[i]}\t");
            }
        }
    }
}
namespace NewNamespace
{
    class NewClass
    {
        public static void Task8()
        {
            /// <summary>
            /// Переставить элементы массива в обратном порядке НЕ используя вспомогательный массив
            /// </summary>
            /// 
            Console.WriteLine();
            Console.WriteLine("Переставить элементы массива в обратном порядке НЕ используя вспомогательный массив");
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]}\t");
            }
            Console.WriteLine();
            for (int i = a.Length - 1; i >= 0; i--) 
            {
                Console.Write($"{a[i]}\t");
            }
        }
        /// <summary>
        /// Подсчитать сумму чисел в двухмерном массиве
        /// </summary>
        public static void Task9()
        {
            Console.WriteLine();
            Console.WriteLine("Подсчитать сумму чисел в двухмерном массиве");
            int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
            int s = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"{m[i, j]}\t");
                    s += m[i, j];
                }
            }
            Console.WriteLine($"S = {s}");
        }
        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 99 и определить количество четных чисел в массиве
        /// </summary>
        public static void Task12()
        {
            //подсказка: для определения остатка от деления используется оператор %
            int ostatok = 4 % 2; //будет равен нулю
            Console.WriteLine();
            Console.WriteLine("Заполнить двумерный массив 10 на 10 случайными числами от 1 до 99 и определить количество четных чисел в массиве");
            int[,] m = new int[3, 3];
            Random rnd = new Random();
            int kol = 0;
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    m[i, j] = rnd.Next(1, 99);
                    if (m[i, j] % 2 == 0) 
                    {
                        kol++;
                    }
                    Console.Write($"{m[i, j]}\t");
                }
            }
            Console.WriteLine($"kol = {kol}");
        }
    }

}