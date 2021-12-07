using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0; // число четных

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
                // положительное число
                if (mas[i] % 2 == 0) num++;
                Console.WriteLine($"m[{i}] = {mas[i]} ");
            }
            Console.WriteLine(); // отступ 
            Console.WriteLine($"Четных элементов: {num}");
            Console.ReadLine();
        }
    }
}
