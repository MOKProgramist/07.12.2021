using System;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявялем размер масива
            Console.Write("Введите размерность массива: ");
            var dlina = int.Parse(Console.ReadLine());
            int[] mas = new int[dlina];

            // номера нулевых элементов массива
            string nol = "";

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
                // запись нулевого айди 
                if (index == 0) nol = nol + i + ", "; 
                Console.WriteLine($"m[{i}] = {index}");
            }
            Console.WriteLine($"Номера нулевых элементов массва: {nol}");
            Console.ReadLine();
        }
    }
}
