using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class J_10_Modul_Massive
    {
        public static void J_10_Modul_Massive_Info(int a)
        {
            Program.ModulRegistr(a);
            if (a == 10)
            {
                int[] mas1 = new int[] { 1, 2, 3, 4, 5, 6, 74, 23, 5, 675, 4, };
                RealizeMas(mas1);
            }
            Program.EndInStart();
        }
            public static void RealizeMasDueMAS(int[,] mas2)
        {
            Console.WriteLine("Модуль 10");
            int rows = mas2.GetUpperBound(0) + 1;
            Console.WriteLine(mas2.GetUpperBound(0) + 1);
            int columns = mas2.Length / rows;
            // или так
            // int columns = mas.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas2[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
        public static void RealizeMas(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = i + 1;
                Console.WriteLine(mas[i]);
            }
        }
    }

}
