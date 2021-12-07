using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявялем размер масива
            Console.Write("Введите размерность массива: ");
            var dlina = int.Parse(Console.ReadLine());
            double[] mas = new double[dlina];

            // запись элементов 
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                mas[i] = double.Parse(Console.ReadLine());
            }

            // вывод элементов массива
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i] * 2} ");
            }
            Console.ReadLine();
        }
    }
}
