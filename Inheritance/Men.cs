using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Men: People
    {
        private string gender = "мужской";

        public string Gender
        {
            get { return gender; }
        }

        public void GenderDisplay()
        {
            Console.WriteLine($"Твой пол - {gender}");
        }

        
        
    }
}
