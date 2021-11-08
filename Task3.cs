using System;

namespace task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int picturesInRowAmount = 3;
            int picturesAmount = 52;

            int rowsAmount = (int)(picturesAmount / picturesInRowAmount);
            int picturesOutOfRangeAmount = picturesAmount - (rowsAmount * picturesInRowAmount);

            Console.WriteLine($"Кол-во полностью заполненных рядов: {rowsAmount}");
            Console.WriteLine($"Кол-во картинок сверх меры: {picturesOutOfRangeAmount}");
        }
    }
}
