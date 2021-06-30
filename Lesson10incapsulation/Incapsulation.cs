using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10incapsulation
{
    /// <summary>
    /// Перевод числа в строку
    /// </summary>
    class IncapsulationExample
    {
        private double doubleValue;
        private string stringValue;

        public double DoubleValue
        {
            get { return doubleValue; }
            set
            {
                doubleValue = value;
                stringValue = value.ToString();
            }
        }
        public string StringValue
        {
            get { return stringValue; }
            set
            {
                stringValue = value;
                try
                {
                    double doubleTemp = Convert.ToDouble(stringValue);
                    doubleValue = doubleTemp;
                }
                catch (Exception)
                {
                    

                }
                
            }
        }
        public void Sum()
        {
            Console.WriteLine($"Число: {doubleValue}");
            Console.WriteLine($"Строка: {stringValue}");
            Console.WriteLine($"Число + строка: {doubleValue + stringValue}");
        }

    }
}
