using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class N_14_Scope_Of_Variables : Modul_Struct
    {
        // контекст класса 
        // контекст метода 
        // контекст блока кода
        static int x = 9; // -----контекст класса 
  //      static int x = 24;  ошибка переменная уже определена
        public static void Scope_Of_Variables_Info(int a)
        {
            if (a == 14)
            {
                Modul_Struct Fourteen = new N_14_Scope_Of_Variables();   //нужно создавать объект класса наследника, после ключевого слова new
                operation_Info_Method_1 = Q_17_Structures.Structures_Create(Code_Writer_Console(a, 1));
                name_Create_Method_1 = "Ключевое слово Params";
                operation_Create_Method_1 = Code_Writer_Console(a, 2);
                name_Examples_Method_1 = "Метод на вывод массива FizzBizz";
                operation_Examples_Method_1 = Code_Writer_Console(a, 3);
                Fourteen.Method_Modul_Start_1();
                int x = 18;
                Console.WriteLine(x); // 19 операция инкремента, операция которая определена на уровне метода ,
                                      // переменная на уровне метода скрыввакт переменную на уровне класса
                x++;
                int d = 8; // только в этом методе
                {
                    int t = 8;  //---- контекст блока кода
                    t++;
                    //for (int i = 0; i < 10; i++)
                    //{
                    //    int t = 8;  //---- контекст блока кода в цикле нельзя опять объявит переменную t
                    //                //т к она используется во включвающей локальной области локальной существующей переменной переменной в области
                    //    t++;
                    //}
                }
                //t++ ошибочно
            }
            Generation_Operation.EndInStart();
        }
        public static void Display()
        { // d++; нельзя тут 
            x = x + 9;  // тут тоже доступна переменная х
            int s = 9; // s -доступна только в этом методе ------ контекст метода 
        }
    }
}
