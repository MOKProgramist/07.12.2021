using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявялем размер масива
            Console.Write("Введите размерность массива: ");
            var dlina = int.Parse(Console.ReadLine());
            int[] mas = new int[dlina];

            // класс random
            Random rnd = new Random();

            // заполнение  массива
            for (int i = 0; i < mas.Length; i++)
            {
                // диапазон от -100 до 100
                mas[i] = rnd.Next(-100, 100);
            }

            // вывод элементов массива в квадрате
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                // текущий элмент массива
                var index = mas[i]; 
                // если число меньше 0 и заменяем элемент числом
                if (index < 0) index = -50;
                Console.WriteLine($"m[{i}] = {(index > 0 ? Math.Pow(index, 2) : index)}");
            }
            Console.ReadLine();
        }
    }
}
