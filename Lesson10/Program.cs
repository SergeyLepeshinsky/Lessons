using System;

namespace Lesson10
{
    class Program
    {
        const string name = "Календарь";

        static void Main(string[] args)
        {
            // ввод от клиента

            Step1((GenderEnum)1, "Иван Петрович");

            Step1(GenderEnum.Women, "Ирина");

            StepWeek1(DayOfWeekEnum.Sunday);
            // приведение типов к enum
            StepWeek1((DayOfWeekEnum)5);
            // распечатать весь список недели 
            PrintAllDay();
            PrintAllGender();
        }
        /// <summary>
        /// метод вывода привествия на экран в зависемости от пола
        /// </summary>
        /// <param name="gender"></param>
        /// <param name="name"></param>
        static void Step1(GenderEnum gender, string name)
        {
            if (gender == GenderEnum.Men)
            {
                Console.WriteLine($"Уважаемый, {name}! ");
            }
            else
            {
                Console.WriteLine($"Уважаемая, {name}!");
            }
            Console.WriteLine("Приветствуем вас на нашем сайте!");
        }
        /// <summary>
        /// Метод по дню недели 
        /// </summary>
        /// <param name="dayOfWeek"></param>
        static void StepWeek1(DayOfWeekEnum dayOfWeek)
        {
            if (dayOfWeek == DayOfWeekEnum.Saturday|| dayOfWeek == DayOfWeekEnum.Sunday) 
            {
                Console.WriteLine($"{DayOfRussian(dayOfWeek)} - выходной");
            }
            else
            {
                Console.WriteLine($"{DayOfRussian(dayOfWeek)} - рабочий день");
            }
        }
        static string DayOfRussian(DayOfWeekEnum dayOfWeek)
        {
            string output = "";
            switch (dayOfWeek)
            {
                case DayOfWeekEnum.Monday:
                    output = "Понедельник";
                    break;
                case DayOfWeekEnum.Tuesday:
                    output = "Вторник";
                    break;
                case DayOfWeekEnum.Wednesday:
                    output = "Среда";
                    break;
                case DayOfWeekEnum.Thursday:
                    output = "Четверг";
                    break;
                case DayOfWeekEnum.Friday:
                    output = "Пятница";
                    break;
                case DayOfWeekEnum.Saturday:
                    output = "Суббота";
                    break;
                case DayOfWeekEnum.Sunday:
                    output = "Воскресенье";
                    break;
                default:
                    break;
            }
            return output;
        }

        static void PrintAllDay()
        {
            foreach (var item in Enum.GetValues(typeof(DayOfWeekEnum)))
            {
                Console.WriteLine(item);
            }
        }
        static void PrintAllGender()
        {
            foreach (var item in Enum.GetValues(typeof(GenderEnum)))
            {
                Console.WriteLine(item);
            }
        }
    }
}
