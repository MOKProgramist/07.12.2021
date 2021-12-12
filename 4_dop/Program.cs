using System;

namespace _4_dop
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявялем размер масива
            Console.Write("Введите размерность массива: ");
            var dlina = int.Parse(Console.ReadLine());
            int[] mas = new int[dlina];

            // ввод массива
            for(int i = 0; i < mas.Length; i++)
            {
                Console.Write($"m[{i}] = ");
                mas[i] = int.Parse(Console.ReadLine());
            }

            // вывод массива
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                // выделяем десяток и еденицу числа
                var a = (mas[i] / 10) % 10;
                var c = mas[i] % 10 ;
                // проверяем десяток и еденицу на равенство
                if(a == c) Console.WriteLine(mas[i]);
            }

            Console.ReadLine();
        }
    }
}
