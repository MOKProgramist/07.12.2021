using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0; // число отрицательных

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
                // отрицательное число
                if (mas[i] < 0) num++;
                Console.WriteLine($"m[{i}] = {mas[i]} ");
            }
            Console.WriteLine(); // отступ 
            Console.WriteLine($"Отрицательных элементов: {num}");
            Console.ReadLine();
        }
    }
}
