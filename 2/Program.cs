using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] mas = new double[5];

            for (int i = 0; i < 5; i++)
            {
                // запись ввода в массив
                Console.Write($"Введите {i} элемент массива: ");
                mas[i] = double.Parse(Console.ReadLine());
            }

            // вывод элементов массива
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }

            Console.ReadLine();
        }
    }
}
