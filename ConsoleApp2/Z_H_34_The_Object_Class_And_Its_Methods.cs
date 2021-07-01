using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Csharp
{
    class Z_H_34_The_Object_Class_And_Its_Methods : Modul_Struct
    {
        public static void Z_H_34_The_Object_Class_And_Its_Methods_Info(int a)
        {
            if (a == 34)
            {
                Modul_Struct thirty_four = new Z_H_34_The_Object_Class_And_Its_Methods();             
                Modul_Struct_Start_With_DB(a, thirty_four,                 // использовать именнованные параметры, пример (x:2, y:3)
                    OperationInfo1_p: Code_Writer_Console(a, 1),
                    NameCreate1_p: "3 версии методов",
                    OperationCreate1_p: Code_Writer_Console(a, 1));
            }
            Generation_Operation.EndInStart();
        }
        public static void Z_H_34_The_Object_Class_And_Its_Methods_Create()
        {

        }
    }
}
