using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0; // число ненулевых

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
                if (mas[i] != 0) num++;
                Console.Write($"{mas[i]} ");
            }
            Console.WriteLine(); // отступ 
            Console.WriteLine($"Элементов не равных \"0\": {num}");
            Console.ReadLine();
        }
    }
}
