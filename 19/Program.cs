using System;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            // объявялем размер масива
            Console.Write("Введите размерность массива: ");
            var dlina = int.Parse(Console.ReadLine());
            int[] mas = new int[dlina];

            // ввод элементов массива
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                mas[i] = int.Parse(Console.ReadLine());
            }

            // вывод массива
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                // текущий элемент 
                var index = mas[i];
                // условие
                if (index < -5 && index < 0) sum++;
                Console.WriteLine($"m[{i}] = {index}");
            }
            Console.WriteLine($"Элементов попало под условие: {sum}");
            Console.ReadLine();
        }
    }
}
