using System;

namespace _5_dop
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
            for (int i = 0; i < mas.Length; i++)
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
                var c = mas[i] % 10;

                // складываем десяток и еденицу и проверяем кратность на 7
                if ((a + c) % 7 == 0 && mas[i] > 0) Console.WriteLine(mas[i]);
            }

            Console.ReadLine();
        }
    }
}
