using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявялем размер масива
            Console.Write("Введите размерность массива: ");
            var dlina = int.Parse(Console.ReadLine());
            double[] mas = new double[dlina];

            // класс random
            Random rnd = new Random();

            // заполнение  массива
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                // диапазон от 0 до 100
                mas[i] = rnd.Next(0, 100);
            }

            // вывод массива
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }
            Console.ReadLine();
        }
    }
}
