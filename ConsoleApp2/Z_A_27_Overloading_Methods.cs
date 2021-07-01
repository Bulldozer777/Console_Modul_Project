using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_A_27_Overloading_Methods : Modul_Struct
    {
        public static void Z_A_27_Overloading_Methods_Info(int a)
        {
            if (a == 27)
            {
                Modul_Struct twenty_seven = new Z_A_27_Overloading_Methods();
                Modul_Struct_Start_With_DB(a, twenty_seven,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "3 версии методов",
                    OperationCreate1_p: Code_Writer_Console(a, 1));

                //3 версии методов
                //Z_A_27_Add(2, 4);
                //Z_A_27_Add(2, 4,6);
                //Z_A_27_Add(2, 4.5);
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {
            Console.WriteLine("Введите 1 чтобы перейти к 1 версии метода Z_A_27_Add (int x, int y)");
            Console.WriteLine("Введите 2 чтобы перейти к 2 версии метода Z_A_27_Add (int x, int y, int z)");
            Console.WriteLine("Введите 3 чтобы перейти к 3 версии метода Z_A_27_Add (double x, double y)");
            Console.WriteLine("Введите 4 чтобы версия метода Z_A_27_Add сработала, исходя от учета введенных параметров ");
            int key = int.Parse(Console.ReadLine());
            if (key == 1)
            {
                Console.WriteLine("Введите 1 число");
                int key1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите 2 число");
                int key2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Код метода:\n");
                Console.WriteLine(Code_Writer_Console(27, 2)+"\n");
                Console.WriteLine("Результат работы метода:\n");
                Z_A_27_Add(key1, key2);
            }
            if (key == 2)
            {
                Console.WriteLine("Введите 1 число");
                int key1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите 2 число");
                int key2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите 2 число");
                int key3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Код метода:\n");
                Console.WriteLine(Code_Writer_Console(27, 3) + "\n");
                Console.WriteLine("Результат работы метода:\n");
                Z_A_27_Add(key1, key2, key3);
            }
            if (key == 3)
            {
                Console.WriteLine("Введите 1 число (double)");
                double key1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите 2 число (double)");
                double key2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Код метода:\n");
                Console.WriteLine(Code_Writer_Console(27, 4) + "\n");
                Console.WriteLine("Результат работы метода:\n");
                Z_A_27_Add(key1, key2);
            }
            if (key == 4)
            {
                //int y1 = 0;
                //double p1 = 0;
                //double p2 = 0;
                int p3 = 0;
                int p4 = 0;
                //int p5 = 0;
                //int p6 = 0;
                try
                {
                    Console.WriteLine("Введите 1 число");
                    int key1 = int.Parse(Console.ReadLine());
                    p3 = key1;
                    //p3 = (int)key1;
                    //p5 = checked((int)key1);

                    Console.WriteLine("Введите 2 число");

                    int key2 = int.Parse(Console.ReadLine());
                    p4 = key2;
                    //p4 = (int)key2;
                    //p6 = checked((int)key2);

                    try
                    {
                        Console.WriteLine("Введите 3 число или нажмите \"Enter\" для запуска метода, использующего 2 параметра");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Type key3 = n.GetType();
                        int y1 = checked((int)n);

                        Console.WriteLine("Результат работы метода, где требуется ввод 3 параметров\n");
                        Z_A_27_Add(key1, key2, n);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Вы ввели 3 число не относящееся к типу int,либо вы ввели \"enter\"");
                        Console.WriteLine("Результат работы метода, где треубется ввод 2 параметров типа Int\n");
                        Z_A_27_Add(key1, key2);
                        Console.WriteLine("Результат работы метода, где треубется ввод 2 параметров типа Double\n");
                        Z_A_27_Add(key1, key2);
                        Console.WriteLine("\nВариант метода где требуется 2 параметра типа double будет без потери данных, \nпоэтому он добавлен сюда\n");
                    }

                    try
                    {
                        Console.WriteLine("Введите 4 число типа double для запуска 3 варианта работы метода \"Z_A_27_Add\"");
                        string key4 = Console.ReadLine();
                        Console.WriteLine("Введите 5 число ");
                        string key5 = Console.ReadLine();
                        double k = Convert.ToDouble(key4);
                        double k1 = Convert.ToDouble(key5);        
                        Console.WriteLine("Результат работы метода, где требуется ввод 2 параметров типа Double\n");
                        Z_A_27_Add(k, k1);
                    }
                    catch
                    {
                        Console.WriteLine("Вы ввели число не относящееся к типу double");
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("\nВводите числа типа int\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Вы ввели 3 число типа не относящееся к типу int");
                    Console.WriteLine("Результат работы метода, где треубется ввод 2 параметров типа Int\n");
                    Z_A_27_Add(p3, p4);
                    Console.WriteLine("Результат работы метода, где треубется ввод 2 параметров типа Double\n");
                    Z_A_27_Add(p3, p4);
                }

                // интересный момент
                //
                //object[] values = {double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), (byte) 12, (sbyte) -5,
                //   16.3, "string" };
                //foreach (var value in values)
                //{
                //    Type t = value.GetType();
                //    if (t.Equals(typeof(byte)))
                //        Console.WriteLine("{0} is an unsigned byte.", value);
                //    else if (t.Equals(typeof(sbyte)))
                //        Console.WriteLine("{0} is a signed byte.", value);
                //    else if (t.Equals(typeof(int)))
                //        Console.WriteLine("{0} is a 32-bit integer.", value);
                //    else if (t.Equals(typeof(long)))
                //        Console.WriteLine("{0} is a 64-bit integer.", value);
                //    else if (t.Equals(typeof(double)))
                //        Console.WriteLine("{0} is a double-precision floating point.",
                //                          value);
                //    else
                //        Console.WriteLine("'{0}' is another data type.", value);
                //}
            }
            else
                Create_Method();
        }     
        public static void Z_A_27_Add(int x, int y)  //методы работают, с одним и тем же именем, если различаются по типу параметров или их количеству, 
            //назвается версия метода
        {
            int result = x + y;
            Console.WriteLine($"Result - {result}\n");
        }
        public static void Z_A_27_Add(int x, int y, int z)
        {
            int result = x + y + z;
            Console.WriteLine($"Result - {result}\n");
        }
        public static void Z_A_27_Add(double x, double y)
        {
            double result = x + y;
            Console.WriteLine($"Result - {result}\n");
        }
    }
}
