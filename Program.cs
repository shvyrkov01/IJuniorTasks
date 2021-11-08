using System;

namespace task6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст: ");
            string userAge = Console.ReadLine();

            Console.WriteLine("Введите ваш пол: ");
            string userSex = Console.ReadLine();

            Console.WriteLine("Введите ваш знак зодиака: ");
            string userZodiac = Console.ReadLine();

            Console.WriteLine("Введите ваше образование: ");
            string userEducation = Console.ReadLine();

            Console.WriteLine("Введите ваше место работы: ");
            string userPlaceWork = Console.ReadLine();

            Console.WriteLine($"Ваше имя - {userName}, ваш возраст - {userAge} лет, ваш пол - {userSex}, ваш знак зодиака - {userZodiac}, ваше образование - {userEducation}, ваше текущее место работы - {userPlaceWork}");
        }
    }
}
