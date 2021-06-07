using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class A_1_First_Program
    {
        public static void FirstProgramCreate(int a)
        {
            if (a == 1)
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("using System; // подключаемое пространство имен\n namespace HelloApp // объявление нового пространства имен \n { \n  class Program   // объявление нового класса \n  { \n   static void Main(string[] args) // объявление нового метода  \n   { \n   Console.WriteLine(\"Hello World!\");// действия метода\n   Calculator.Add(2, 3);//Класс Calculator метод Add код ниже  \n   } // конец объявления нового метода  \n  } // конец объявления нового класса  \n } // конец объявления нового пространства имен \n");
                Console.WriteLine("Отдельно код класса Calculator");
                Console.WriteLine("\nclass Calculator\n{\n public static void Add(int x, int y)\n {\n  int z = x + y;\n  Console.WriteLine($\"Сумма {x} и {y} равна {z} \");\n }\n}");
                Console.WriteLine("Результат действия метода Add, класса Calculator:\n");
                Calculator.Add(2, 3);
                Generation_Operation.EndInStart();
            }
        }
    }
    class Calculator
    {
        public static void Add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine($"Сумма {x} и {y} равна {z} ");
        }
    }
}
