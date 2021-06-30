using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class People
    {
        private string name;
        private int age;
        

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
        public void Display()
        {
            Console.WriteLine($"Привествую тебя, {name}! Твой возраст {age} лет");
        }
    }
}
