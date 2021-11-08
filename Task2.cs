using System;

namespace Task2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int serviceTimeMinutes = 10;

            Console.WriteLine("Введите кол-во человек в очереди перед вами: ");

            if (!int.TryParse(Console.ReadLine(), out int numberPersons))
                throw new ArgumentException("Вы должны ввести число!");

            TimeSpan waitingTime = new TimeSpan(0, serviceTimeMinutes * numberPersons, 0);

            Console.WriteLine($"Время вашего ожидания состовляет: {waitingTime.Hours} часа {waitingTime.Minutes} минут");
        }
    }
}
