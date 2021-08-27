using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class A_1_First_Program : Modul_Struct
    {
        public static void FirstProgramCreate(int a)
        {
            if (a == 1)
            {
                Console.WriteLine("Hello World!");
              
                Modul_Struct One = new A_1_First_Program();   //нужно создавать объект класса наследника, после ключевого слова new
                One.Operation_Info_Method_1 = Q_17_Structures.Structures_Create(Code_Writer_Console(a, 1));
                One.Name_Create_Method_1 = "Отдельно код класса Calculator";
                One.Operation_Create_Method_1 = Code_Writer_Console(a, 2);            
                One.Method_Modul_Start_1(a);
                Calculator.Add(2, 3);            
                Generation_Operation.EndInStart();
            }
        }
        public override void Coddition_Create_Type_Method_1()
        {
            Console.WriteLine("Результат действия метода Add, класса Calculator:\n");
            Calculator.Add(2, 3);
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
