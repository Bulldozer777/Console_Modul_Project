using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_J_36_Generics : Modul_Struct
    {
        public static void Z_J_36_Generics_Info(int a)
        {
            if (a == 36)
            {
                Modul_Struct thirty_six = new Z_J_36_Generics();
                thirty_six.operation_Info_Method_1 = Q_17_Structures.Structures_Create(Code_Writer_Console(a, 1));
                thirty_six.name_Create_Method_1 = "Ключевое слово Params";
                thirty_six.operation_Create_Method_1 = Code_Writer_Console(a, 2);
                thirty_six.name_Examples_Method_1 = "Метод на вывод массива FizzBizz";
                thirty_six.operation_Examples_Method_1 = Code_Writer_Console(a, 3);
                thirty_six.Create_Create_Method_7_string = "Введите порядковый номер числа Фиббоначи";
                thirty_six.Name_Create_Method_7 = "Порядковый номер числа Фиббоначи";

                //= int.Parse(Console.ReadLine());
                thirty_six.Create_Create_Method_7_int = O_15_Recursive_Functions.Fibbonacci(thirty_six.Create_Create_Method_7_int2);
                thirty_six.Method_Modul_Start_1();
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_J_36_Generics_Create()
        {

        }
        //public static int Fibbonacci(int n)
        //{
        //    if (n == 0)
        //    {
        //        return 0;
        //    }

        //    if (n == 1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        int z = Fibbonacci(n - 1) + Fibbonacci(n - 2);
        //        return z;
        //    }
        //}
    }
}
