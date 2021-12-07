using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявялем размер масива
            Console.Write("Введите размерность массива: ");
            var dlina = int.Parse(Console.ReadLine());
            double[] mas = new double[dlina];

            // ввод элементов массива
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                mas[i] = double.Parse(Console.ReadLine());
            }

            // вывод массива
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{Math.Sqrt(mas[i]):0.00} ");
            } 
            Console.ReadLine();
        }
    }
}
