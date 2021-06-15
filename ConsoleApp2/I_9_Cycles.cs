using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class I_9_Cycles : Modul_Struct
    {
        public static void I_9_Cycles_Info(int a)
        {
            //Program.ModulRegistr(a);
            if (a == 9)
            {
                Console.WriteLine("\nfor" +
                    "\nwhile" +
                    "\ndo ... while" +
                    "\nforeach");
                Modul_Struct Nine = new I_9_Cycles();   //нужно создавать объект класса наследника, после ключевого слова new
                operation_Info_Method_1 = Q_17_Structures.Structures_Create(Code_Writer_Console(a, 1));
                operation_Create_Method_1 = Code_Writer_Console(a, 2);
                operation_Create_Method_2 = Code_Writer_Console(a, 3);
                name_Examples_Method_1 = "Cоздание рандомной строки"; //сюда вводятся имена методов, используемые в Examples_Method()
                name_Examples_Method_2 = "Вычисление числа Фиббоначи по порядковому номеру";
                name_Examples_Method_3 = "Группа методов введите пароль \"root\" с помощью разных циклов";
                name_Examples_Method_4 = "Последовательность";
                //name_Examples_Method_5 = ;
                operation_Examples_Method_1 = Code_Writer_Console(a, 4);
                operation_Examples_Method_2 = Code_Writer_Console(a, 5);
                operation_Examples_Method_3 = Code_Writer_Console(a, 6);
                operation_Examples_Method_4 = Code_Writer_Console(a, 7);
                operation_Examples_Method_5 = Code_Writer_Console(a, 8);
                operation_Examples_Method_6 = Q_17_Structures.Structures_Create(Code_Writer_Console(a, 9));
                operation_Examples_Method_7 = Code_Writer_Console(a, 10);
                Nine.Method_Modul_Start_1();
                Generation_Operation.EndInStart();
            }
            Generation_Operation.EndInStart();
        }
        public override void Create_Method()
        {
            Console.WriteLine("Чтобы запустить метод I_9_Cycles_Create() Нажмите 1\n");
            Console.WriteLine("Чтобы запустить метод Factorial_in_Cycles() и увидеть его код Нажмите 2\n");
            Console.WriteLine("Чтобы перейти в выбору другогой темы модуля модуля нажмите 3");
            Console.WriteLine("Чтобы перейти в выбору другого модуля модуля нажмите 4");
            int y = int.Parse(Console.ReadLine());           
            if (y == 1)
            {
                Console.WriteLine("Код метода I_9_Cycles_Create()");
                Console.WriteLine($"{operation_Create_Method_1}");
                Console.WriteLine("\nРабота метода:\n");
                I_9_Cycles_Create();
                Create_Method();
            }
            if (y == 2)
            {
                Console.WriteLine("Код метода Factorial_in_Cycles()");
                Console.WriteLine($"{operation_Create_Method_2}");
                Console.WriteLine("Работа метода");
                Factorial_in_Cycles();
                Create_Method();
            }
            if (y == 3)
            {
                Console.Clear();
                Method_Modul_Start_1();
            }
            if (y == 4)
            {
                Console.Clear();
                Generation_Operation.EndInStart();
            }

            if (y > 5 || y < 1)
            {
                Console.WriteLine("Вы ввели неверное число, введите число от 1-7, чтобы запустить необходимый метод");
                Method_Modul_Start_1();
            }
            else
            {
                Console.WriteLine("Вы ввели неверное число");
            }
        }
        public override void Examples_Method()
        {
            Console.WriteLine($"\nЧтобы запустить {name_Examples_Method_1} нажмите 1 ");
            Console.WriteLine($"Чтобы запустить {name_Examples_Method_2} нажмите 2 ");
            Console.WriteLine($"Чтобы запустить {name_Examples_Method_3} нажмите 3 ");
            Console.WriteLine($"Чтобы запустить {name_Examples_Method_4} нажмите 4 ");
            Console.WriteLine("Чтобы перейти в выбору другогой темы модуля модуля нажмите 5");
            Console.WriteLine("Чтобы перейти в выбору другого модуля модуля нажмите 6");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.Clear();
                Console.WriteLine($"{operation_Examples_Method_1}");
                Console.WriteLine($"Вывод результата работы метода \"{name_Examples_Method_1}\" на консоль ");
                RandomString();
               
                Examples_Method();
            }
            if (x == 2)
            {
                Console.Clear();
                Console.WriteLine($"{operation_Examples_Method_2}");
                Console.WriteLine($"Вывод результата работы метода \"{name_Examples_Method_2}\" на консоль");
                FibbCreate();
                Examples_Method();
            }
            if (x == 3)
            {
                Console.Clear();               
                Console.WriteLine($"Чтобы запустить пример через цикл while нажмите 1 ");
                Console.WriteLine($"Чтобы запустить пример через цикл do ... while нажмите 2 ");
                Console.WriteLine($"Чтобы запустить пример через цикл for нажмите 3 ");
                int e = int.Parse(Console.ReadLine());
                if (e == 1)
                {
                    Console.WriteLine($"{operation_Examples_Method_3}");
                    Password_Cycles_1();
                }
                if (e == 2)
                {
                    Console.WriteLine($"{operation_Examples_Method_4}");
                    Password_Cycles_2();
                }
                if (e == 3)
                {
                    Console.WriteLine($"{operation_Examples_Method_5}");
                    Password_Cycles_3();
                }
                Examples_Method();
            }
            if (x == 4)
            {
                Console.Clear();
                Console.WriteLine($"{operation_Examples_Method_4}");
                Console.WriteLine($"Вывод результата работы метода \"{name_Examples_Method_4}\" на консоль");
                Sequence(); //нормально не работает
                Examples_Method();
            }
            if (x == 5)
            {
                Console.Clear();
                Method_Modul_Start_1();
            }
            if (x == 6)
            {
                Console.Clear();
                Generation_Operation.EndInStart();
            }

            if (x > 6 || x < 1)
            {
                Console.WriteLine("Вы ввели неверное число, введите число от 1-6, чтобы запустить необходимый метод");
                Method_Modul_Start_1();
            }
        }
        public static void RandomString()
        {
            Console.WriteLine("Введите длину рандомной строки");
           int length = int.Parse(Console.ReadLine());

            var result = new char[length];
            var r = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                do
                    result[i] = (char)r.Next(127);
                while (result[i] < '!');
            }
            Console.WriteLine(result);
        }
        public static int FibbCreate()
        {
            Console.WriteLine("Введите порядковый номер числа Фиббоначи");
            int Fibb1 = int.Parse(Console.ReadLine());
            int[] Fib = new int[100];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i < Fib.Length; i++)
            {
                Fib[i] = Fib[i - 1] + Fib[i - 2];
            }
            int bb = Fibb1;
            int m;
            m = Fib[bb];
            return m;
        }
        public static void Password_Cycles_1()
        {
            //через while          
            Console.WriteLine("\nПрограмма будет спрашивать пароль до тех пор, пока не будет введен пароль: \"root\"");
            Console.WriteLine("через while");
            Console.WriteLine("Введите пароль");
            string a = Console.ReadLine();
            while (a != "root")
            {
                Console.WriteLine("Введите пароль");
                a = Console.ReadLine();
            }

            Console.WriteLine("Правильный пароль");
        }
            public static void Password_Cycles_2()
        {
            Console.WriteLine("\nПрограмма будет спрашивать пароль до тех пор, пока не будет введен пароль: \"root\"");
            Console.WriteLine("через do ... while");
            string a2 = "";
            do
            {
                Console.WriteLine("Введите пароль");
                a2 = Console.ReadLine();
            }
            while (a2 != "root");
            Console.WriteLine("Правильный пароль");
        }
        //через do ... while

        public static void Password_Cycles_3()
        {
            //Через for
            Console.WriteLine("\nПрограмма будет спрашивать пароль до тех пор, пока не будет введен пароль: \"root\"");
            Console.WriteLine("Через for");
            string a3 = " ";
            Console.WriteLine("Введите пароль");
            a3 = Console.ReadLine();
            for (int i = 0; a3 != "root"; i++)
            {
                Console.WriteLine("Введите пароль");
                a3 = Console.ReadLine();
            }
            Console.WriteLine("Правильный пароль");
        }
    public static void Sequence()
        {
            int t;
            Console.WriteLine("Введите 1 элемент последовательности");
            t = int.Parse(Console.ReadLine());
            int u;
            Console.WriteLine("Введите количество элементов последовательности");
            u = int.Parse(Console.ReadLine());
            int z;
            Console.WriteLine("Введите на сколько должен увеличиваться каждый элемент последовательности");
            z = int.Parse(Console.ReadLine());
            int r = t + z * u;
            Console.WriteLine(" ");
            List<int> teams = new List<int>(r) { };
            for (int i = 1; i < teams.Capacity; i = i + z)
            {
                Console.WriteLine($"{i} - элемент последовательности {((i) / 3) + 1}   ");
            }
        }
public static void I_9_Cycles_Create()
        {
            //for (счетчик; условие; изменение счетчика)
            //{

            //}
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"Квадрат числа - {i} = { i*i}");
            }
            int j = 0; //счетчик можно бъявить вне цикла
            for (; j < 9; j++)
            {
                Console.WriteLine($"Квадрат числа - {j} = { j * j}");
            }
            int k = 0; //счетчик можно бъявить вне цикла
            for (; k < 9; )
            {
                k++; //можно опустить приращение(изменение) цикла в сам цикл
                Console.WriteLine($"Квадрат числа - {k} = { k * k}");
            }
            int e = 6; //счетчик
            while(e > 0)
            {
                Console.WriteLine(e);
                e--; //изменение цикла
            }
            int y = -4;
            do //сначала выполняет выражение, потом смотрит условие
            {
                Console.WriteLine(y);
                y--;
            }
            while (y > 0);
            int u = 0;
            for (; u < 9; u++)
            {
                if(u==5)           
                {
                    break; //в цикле работают операторы, оператор break завершает работыу цикла,
                           //в данном случае при u=5
                }
                if(u==6)
                {
                    continue;//оператор continue пропускает итерацию цикла при u=6
                             //в данном случае не выполниться т к выше выполниться оператор break
                }
                Console.WriteLine($"{u}");
            }
        }
        public static void Factorial_in_Cycles()
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            Console.WriteLine($"Факториал {n} = {result}"); 
          
          
        }
        public static void Info_TryParse()
        {
            string[] values = { null, "160519", "9432.0", "16,667",
                          "   -322   ", "+4302", "(100);", "01FA" };
            foreach (var value in values)
            {
                double number;

                bool success = double.TryParse(value, out number);
                if (success)
                {
                    Console.WriteLine("Converted '{0}' to {1}.", value, number);
                }
                else
                {
                    Console.WriteLine("Attempted conversion of '{0}' failed.",
                                       value ?? "<null>");
                }
            }
        }
        public static void Info_1_TryParse()
        {
            decimal i;//int.Parse(Console.ReadLine());
            while (!decimal.TryParse(Console.ReadLine(), out i)) //TryParse принимает два аргумента, первый аргумент строка
                                                                 //второй аргумент int32 
            {
                Console.WriteLine("Введите десятичную дробь");
            }
            Console.WriteLine(i);
        }
    }
}
