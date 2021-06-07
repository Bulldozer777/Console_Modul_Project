using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class D_4_Arithmetic_Operations
    {
        public static void ArithmeticOperationsInfo(int a)
        {
            if (a == 4)
            {
                Console.WriteLine("Арифметические операции");
                Console.WriteLine("Чтобы запустить метод \"Binar_Operations\" нажмите 1 ");
                Console.WriteLine("Чтобы запустить метод \"Incremet_Decrement()\" нажмите 2 ");
                int x = int.Parse(Console.ReadLine());
                Incremet_Decrement(x);
                Binar_Operations(x);
                while (x != 1)
                {
                    Console.WriteLine("Чтобы запустить метод \"Binar_Operations\" нажмите 1 ");
                    Console.WriteLine("Чтобы запустить метод \"Incremet_Decrement()\" нажмите 2 ");
                    Console.WriteLine("Если Вы хотите перейти к дургому модулю, нажмите 3");
                    int x1 = int.Parse(Console.ReadLine());
                    Binar_Operations(x1);
                    Incremet_Decrement(x1);
                    if (a != 1)
                    {
                        Console.WriteLine("Если Вы хотите перейти к дургому модулю, нажмите 3");
                        int x2 = int.Parse(Console.ReadLine());
                        if (x2 == 3)
                        {
                            Generation_Operation.EndInStart();
                        }
                        else
                        {
                            Console.WriteLine("Нажмите 2 или 1, для перехода к другому модулю нажмите 3");
                        }
                    }
                }
            }
            Generation_Operation.EndInStart();
        }
        public static void Binar_Operations(int h)
        {
            if (h == 1)
            {
                Console.WriteLine("Чтобы запустить операцию сложения, метод \"Binar_Addition_Operations\" нажмите 1 ");
                Console.WriteLine("Чтобы запустить операцию вычитания, метод \" Binar_Subtraction_Operations\" нажмите 2 ");
                Console.WriteLine("Чтобы запустить операцию умножения, метод \"Binar_Multiplication_Operations\" нажмите 3 ");
                Console.WriteLine("Чтобы запустить операцию деления, метод \"Binar_Division_Operations\" нажмите 4 ");
                string f = "Реузльтат = ";
                int u = int.Parse(Console.ReadLine());
                if (u == 1 | u == 2 | u == 3 | u == 4)
                {
                    if (u == 1)
                    {
                        Console.WriteLine($"{f} {Binar_Addition_Operations()}");
                        GetEnd();

                    }
                    if (u == 2)
                    {
                        Console.WriteLine($"{f} {Binar_Subtraction_Operations()}");
                        GetEnd();

                    }
                    if (u == 3)
                    {
                        Console.WriteLine($"{f} {Binar_Multiplication_Operations()}");
                        GetEnd();
                    }
                    if (u == 4)
                    {
                        Console.WriteLine($"{f} {Binar_Division_Operations()}");
                        GetEnd();
                    }
                }
                else
                {
                    Console.WriteLine($"Вы ввели неверное число");
                }
            }
        }
        public static int Binar_Addition_Operations()
        {
            Console.WriteLine("Операции сложения двух чисел");
            Console.WriteLine("введите число");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine($"int x = {i}; \n int z = {i} + 12; // 22");
            int z = i + 12;
            return z;
        }
        public static int Binar_Multiplication_Operations()
        {
            Console.WriteLine("Операции умножения двух чисел");
            Console.WriteLine("введите число");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine($"int x = {i}; \n int z = {i} * 12; ");
            int z = i * 12;
            return z;
        }
        public static int Binar_Subtraction_Operations()
        {
            Console.WriteLine("Операции сложения двух чисел");
            Console.WriteLine("введите число");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine($"int x = {i}; \n int z = {i} - 6; ");
            int z = i - 6;
            return z;
        }
        public static int Binar_Division_Operations()
        {
            Console.WriteLine("Операции сложения двух чисел");
            Console.WriteLine("введите число");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine($"int x = {i}; \n int z = {i} / 12; ");
            Console.WriteLine("При делении стоит учитывать, что если оба операнда представляют целые числа, то результат также будет округляться до целого числа:");
            int z = i / 12;
            return z;
        }
        public static void GetEnd()
        {
            Console.WriteLine("Введите 1, чтобы запустить Binar_Operations");
            Console.WriteLine("Введите 2, чтобы запустить Incremet_Decrement");
            Console.WriteLine("Если Вы хотите перейти к дургому модулю, нажмите 3");
            int x1 = int.Parse(Console.ReadLine());
            Binar_Operations(x1);
            Generation_Operation.EndInStart();
        }
        public static void Incremet_Decrement(int i)
        {
            if (i == 2)
            {
                Console.WriteLine("int x1 = 5; \n int z1 = ++x1; // z1=6; x1=6");
                int x1 = 5;
                int z1 = ++x1; // z1=6; x1=6
                Console.WriteLine($"x1 = {x1} z1 = {z1}");
            }
            else
            {
                Console.WriteLine("Выввели неверное число");
                GetEnd();
            }
        }
    }
}
