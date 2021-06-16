using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class J_10_Modul_Massive : Modul_Struct
    {
        public static void J_10_Modul_Massive_Info(int a)
        {
            Generation_Operation.ModulRegistr(a);
            if (a == 10)
            {
                Modul_Struct Ten = new J_10_Modul_Massive();   //нужно создавать объект класса наследника, после ключевого слова new
                Ten.operation_Info_Method_1 = Q_17_Structures.Structures_Create(Code_Writer_Console(a, 1));
                Ten.name_Create_Method_1 = "Определение массива";
                Ten.operation_Create_Method_1 = Code_Writer_Console(a, 2);
                Ten.name_Create_Method_2 = "Вывод массива";
                Ten.operation_Create_Method_2 = Code_Writer_Console(a, 3);
                Ten.name_Create_Method_3 = "Многомерные массивы";
                Ten.operation_Create_Method_3 = Code_Writer_Console(a, 4);
                Ten.name_Create_Method_3 = "Зубчатые массивы";
                Ten.operation_Create_Method_3 = Code_Writer_Console(a, 5);
                Ten.name_Examples_Method_1 = "Программа создает массив из 10 элементов и выводит минимальный элемент";
                Ten.operation_Examples_Method_1 = Code_Writer_Console(a, 6);
                Ten.name_Examples_Method_2 = "Программа выводит количество положительных чисел в массиве:";
                Ten.operation_Examples_Method_2 = Code_Writer_Console(a, 7);
                Ten.Method_Modul_Start_1();
            }
            Generation_Operation.EndInStart();
        }
        public static int MassMin(int[] mas)
        {
            int min = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                }
            }
            return min;
        }
        public override void Coddition_Create_Type_Method_1()
        {
            Definition_Mas_Method();                
        }
        public override void Coddition_Create_Type_Method_2()
        {
            Conclusion_Mas();
        }
        public override void Coddition_Create_Type_Method_3()
        {
            RealizeMasDueMAS();
        }
        public override void Coddition_Create_Type_Method_4()
        {
            Toothed_Mas();
        }
        public static void RealizeMasDueMAS()
        {
            int[,] mas2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            int rows = mas2.GetUpperBound(0) + 1;
            Console.WriteLine(mas2.GetUpperBound(0) + 1);
            //И если мы говорим непосредственно о двухмерном массиве,
            //то первая размерность (с индексом 0) по сути это и есть таблица.
            //И с помощью выражения mas.GetUpperBound(0) + 1 можно получить количество строк таблицы,
            //представленной двухмерным массивом.
            //А через mas.Length / rows можно получить количество элементов в каждой строке:

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
        public static void Toothed_Mas()
        {
            int[][] numbers = new int[3][];
            numbers[0] = new int[] { 1, 2 };
            numbers[1] = new int[] { 1, 2, 3 };
            numbers[2] = new int[] { 1, 2, 3, 4, 5 };
            foreach (int[] row in numbers)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }

            // перебор с помощью цикла for
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write($"{numbers[i][j]} \t");
                }
                Console.WriteLine();
            }
        }
        public static void Definition_Mas_Method()
        {
            int[] nums2 = new int[4] { 1, 2, 3, 5 };

            int[] nums3 = new int[] { 1, 2, 3, 5 };

            int[] nums4 = new[] { 1, 2, 3, 5 };

            int[] nums5 = { 1, 2, 3, 5 };
           
            foreach (int i in nums2)
            {
                Console.WriteLine(i); 
            }
        }
        public static void Conclusion_Mas()
        {           
            int[] numbers = new int[] { 1, 2, 3, 4, 5 }; //через for
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("\n");
            foreach (int i in numbers)          //через foreach
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < numbers.Length; i++)//В то же время цикл for более гибкий по сравнению с foreach.
                                                    //Если foreach последовательно извлекает элементы контейнера
                                                    //и только для чтения,
                                                    //то в цикле for мы можем перескакивать на несколько элементов
                                                    //вперед в зависимости от приращения счетчика,
                                                    //а также можем изменять элементы:
            {
                numbers[i] = numbers[i] * 2;
                Console.WriteLine(numbers[i]);
            }
        }
        public override void Coddition_Examples_Type_Method_1()
        {
            Create_Mas();
        }
        public override void Coddition_Examples_Type_Method_2()
        {
            Positive_Elements_Mas();
        }
        public static void RealizeMas(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = i;
                Console.WriteLine(mas[i]);

            }
        }
        public static void Create_Mas()
        {
            Console.WriteLine("Начальный массив");
            int[] mas = new int[10];
            Random u = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = u.Next(-245, 35);
            }
            foreach (int i in mas)
            {
                Console.WriteLine(i);
            }          
            Console.WriteLine($"Минимальный элемент массива - {MassMin(mas)}");
        }  
        public static void Positive_Elements_Mas()
        {
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int result = 0;
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    result++;
                }
            }
            Console.WriteLine($"Число элементов больше нуля: {result}");
        }

    }
}

