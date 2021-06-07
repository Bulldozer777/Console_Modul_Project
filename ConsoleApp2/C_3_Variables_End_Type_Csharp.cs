using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class C_3_Variables_End_Type_Csharp
    {
        public static void TypeScharpExperience(int a)
        {
            Console.WriteLine("Переменные и типы данных");
            if (a == 3)
            {
                // int a = 9;
                object obj = 10; // тип обджект 
                Console.WriteLine("метод возвращает тот тип который обджект определил для себя при инициализации,\tobject obj = 10;  тип int будет возвращать GetTeype");
                Console.WriteLine(obj.GetType()); // метод возвращает тот тип который обджект определил для себя при инициализации
                                                  //  object obj = 10;  тип int будет возвращать GetTeype
                var b = 5;
                Console.WriteLine(Convert.ToString(-10, 2));  // Вывод числа в двоичной системе счисления (число, система счисления)
                Console.WriteLine(b.GetType());
                Program.EndInStart();
            }
            }
    }
}
