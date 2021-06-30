using System;

namespace Lesson10incapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            var incapsulation = new IncapsulationExample();
            Console.WriteLine(incapsulation.GetType());

            incapsulation.DoubleValue = 0.0001;
            string s = incapsulation.StringValue;
            Console.WriteLine(s);

            incapsulation.Sum();

            incapsulation.StringValue = "qwert";

            incapsulation.Sum();



        }
    }
}
