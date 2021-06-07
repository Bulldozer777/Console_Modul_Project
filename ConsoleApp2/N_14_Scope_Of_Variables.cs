using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class N_14_Scope_Of_Variables
    {
        // контекст класса 
        // контекст метода 
        // контекст блока кода
        static int x = 9; // -----контекст класса 
  //      static int x = 24;  ошибка переменная уже определена
        public static void Scope_Of_Variables_Info(int a)
        {
            Program.ModulRegistr(a);
            if (a == 14)
            {
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
            Program.EndInStart();
        }
        public static void Display()
        { // d++; нельзя тут 
            x = x + 9;  // тут тоже доступна переменная х
            int s = 9; // s -доступна только в этом методе ------ контекст метода 
        }
    }
}
