using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Y_25_Constants_And_Read_Fields : Modul_Struct
    {
        public static void Y_25_Constants_And_Read_Fields_Info(int a)
        {
            if (a == 25)
            {
                Modul_Struct twenty_five = new Y_25_Constants_And_Read_Fields();
                Modul_Struct_Start_With_DB(a, twenty_five,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 3),
                    NameCreate1_p: "Определние константы и присвоение переменной, значения константы",
                    OperationCreate1_p: Code_Writer_Console(a, 1),
                    NameCreate2_p: "Определние поля readonly и присвоение переменной, значения полю readonly",
                    OperationCreate2_p: Code_Writer_Console(a, 2));
            }
            Generation_Operation.EndInStart();
        }
        public override void Coddition_Create_Type_Method_1()
        {
            int r = MathLib.T;

            //присвоение переменной, значения константы
            //MathLib.T = 9; из вне нельзя изменить значение константы 

            Console.WriteLine($"\nПоле константа - {r}\n");
        }
        public override void Coddition_Create_Type_Method_2()
        {
            MathLib Obj = new MathLib();

            // Obj.p = 90; - некорректная запись поле реадонли изменить нельзя

            int u = Obj.p;

            // можно только присвоить

            Console.WriteLine($"\nПоле Readonly - {u} \n");
        }
    }
    class MathLib
    {
        public const int T = 67; // название константы определяется в верхнем регистре
        public readonly int p = 89; //поле для чтения 
        public MathLib() //констурктор
        {
            //  T = 78; некорректное опредление т к переменная это костанта
            p = 78; //- корректная запись в отличие от констант
        }
        public void Some()
        {
            //  T = 78; некорректное опредление т к переменная это костанта
          //  p = 78; //- некорректная запись 
        }
    }
}
