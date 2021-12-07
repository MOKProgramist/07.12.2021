using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0; // число нечетных

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
                mas[i] = rnd.Next(50, 1000);
            }


            // вывод элементов массива
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > max) max = (int) mas[i];
                Console.WriteLine($"m[{i}] = {mas[i]} ");
            }
            Console.WriteLine(); // отступ 
            Console.WriteLine($"Максимум: {max}");
            Console.ReadLine();
        }
    }
}
