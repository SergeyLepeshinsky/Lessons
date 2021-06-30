using System;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            People people = new People() { Name = "Алиса", Age = 15 };

            people.Display();

            people = new Men() { Name = "Артемий", Age = 30 };

            people.Display();

            Men people2 = new Men() { Name = "Сергей", Age = 20};

            people2.Display();

            people2.GenderDisplay();

        }
       
        
       
    }
}
