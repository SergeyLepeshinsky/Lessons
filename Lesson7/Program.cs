using System;
using DogName = Lesson7.Dogs.Dog.Name;
using DogDescription = Lesson7.Dogs.Dog.Name.Dog.Description;
using Lesson7.Arifm;


namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");
            Ar();
            Dogs();




        }
        static void Ar()
        {
            Arif.NameA = Vvod();
            Arif.NameB = Vvod();
            Console.WriteLine(Arif.Results.AllOperation());
            Console.WriteLine();

        }
        static double Vvod()
        {
            Console.Write($"Выбрано число = ");
            Random rnd = new Random();
            double v = (double)rnd.Next(-100, 100);
            Console.WriteLine(v);
            return v;
           
        }
        // разные варианты вывода
        static void Dogs()
        {
            Console.WriteLine($"Выбрано число = {Arif.NameA}");
            if (Arif.NameA >= 0) 
            {

                Console.WriteLine(DogName.EuropeBeagle.Name);
                Console.WriteLine(DogDescription.EuropeBeagle.Name());
            }
            else
            {
                Console.WriteLine(DogName.EnglishBeagle.Name());
                Console.WriteLine(DogDescription.EnglishBeagle.Name()); 
            }
        }
    }
}


