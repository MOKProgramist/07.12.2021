using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявялем размер масива
            Console.Write("Введите размерность массива: ");
            var dlina = int.Parse(Console.ReadLine());
            double[] mas = new double[dlina];

            // заполнение  массива
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                mas[i] = double.Parse(Console.ReadLine());
            }

            // вывод массива в обратном порядке
            for (int i = mas.Length - 1; i >= 0; i--)
            {
                Console.Write($"{mas[i]} ");
            }
            Console.ReadLine();
        }
    }
}
