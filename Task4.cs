using System;

namespace task4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int goldAmount;
            int diamondAmount;

            int diamondCost = 3;

            Console.WriteLine("Введите начальное кол-во золота: ");

            goldAmount = TryConvertToInt(Console.ReadLine());

            Console.WriteLine($"Цена одного Кристалла: {diamondCost}\nВведите количество Кристаллов, которое хотите приобрести:");

            int diamondTarget = TryConvertToInt(Console.ReadLine());

            goldAmount -= (diamondTarget * diamondCost);
            diamondAmount = diamondTarget;

            Console.WriteLine($"Кошелек\nЗолота:{goldAmount}\nКристаллов: {diamondAmount}");
        }


        private static int TryConvertToInt(string inputText)
        {
            if (!int.TryParse(inputText, out int value))
                throw new ArgumentException("Вы должны ввести число!");

            return value;
        }
    }
}
