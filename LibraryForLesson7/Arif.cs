using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Arifm
{
    public class Arif
    {
        public static double NameA { get; set; }
        public static double NameB { get; set; }

        private class Actions
        {
            public static string Sum()
            {
                return $"Пример сложения: {NameA} + {NameB} = {NameA + NameB} \n";
            }
            public static string Sub()
            {
                return $"Пример вычитания: {NameA} - {NameB} = {NameA - NameB} \n";
            }
            public static string Multi()
            {
                return $"Пример умножения: {NameA} * {NameB} = {NameA * NameB} \n";
            }
            public static string Divn()
            {
                string s;
                if (NameB == 0)
                {
                    s = "Деление невозможно";
                }
                else
                {
                    s = $"Пример деления: {NameA} / {NameB} = {NameA / NameB} \n";
                }
                return s;
            }
        }
        public class Results
        {
            public static string AllOperation()
            {
                return $"{Actions.Sum()}{Actions.Sub()}{Actions.Multi()}{Actions.Divn()}";
            }
        }
        
        
    }
}
