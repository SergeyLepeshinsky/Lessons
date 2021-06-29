using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Dogs
{
    namespace Dog.Name
    {
        public class EuropeBeagle
        {
            public static string Name => "Это Европейский бигль!";

        }
        public class EnglishBeagle
        {
            public static string Name() => "Это Английский бигль!";
        }
        namespace Dog.Description
        {
            public class EuropeBeagle
            {
                public static string Name()
                {
                    return @"
        Французский бигль-харьер — гончая родом из Франции! 
        Два вида ранее были исключительно гончими, и, исходя из этого, можно сделать вывод, 
        что барон своим экспериментом просто замкнул круг. У таких собак достаточно крепкий костяк, 
        хорошая сила, вес достигает 20 кг, а высота колеблется от 38 до 48 см в холке.";
                }
            }
            public class EnglishBeagle
            {
                public static string Name()
                {
                    return @"
        Бигль – английская гончая порода собак, отличающаяся небольшими размерами и милым внешним видом. 
        Как и большинству гончих, собакам этой породы свойственны такие черты, как острый нюх, 
        скорость реакции и высокий уровень социальности. Отличаются поразительным расположением к людям и добротой.";
                }
            }
        }
    }
}
